using Bogus;

using Microsoft.EntityFrameworkCore;

using Payments.Domain.Entities;
using Payments.Domain.Enum;
using Payments.Infrastructure.Persistence;

namespace Payments.DatabaseSeeder;

public record DatabaseSeeder(IDbContextFactory<DatabaseContext> DbContextFactory)
{
    private readonly List<string> _currencyGroupsNames = ["Crypto", "Stock", "Futures", "Metals", "Coins", "Stable coins"];

    public async Task SeedDatabaseAsync()
    {
        var currencies = GenerateCurrencies(50);
        var currencyGroups = GenerateCurrencyGroups(10, currencies);
        var paymentSystems = GeneratePaymentSystems(10, 10, currencies);
        var payments = GeneratePayments(50);
        LinkPayments(paymentSystems, payments);

        await using var dbContext = await DbContextFactory.CreateDbContextAsync();
        await dbContext.Currencies.AddRangeAsync(currencies);
        await dbContext.CurrencyGroups.AddRangeAsync(currencyGroups);
        await dbContext.PaymentSystems.AddRangeAsync(paymentSystems);
        await dbContext.SaveChangesAsync();
    }

    private List<Currency> GenerateCurrencies(int amount) =>
        new Faker<Currency>().RuleFor(x => x.Id, f => Guid.NewGuid())
                             .RuleFor(x => x.Name, f => f.Finance.Currency().Code)
                             .Generate(amount).DistinctBy(x => x.Name).ToList();

    private List<CurrencyGroup> GenerateCurrencyGroups(int currencyAmount, List<Currency> currencies)
    {
        var index = 0;
        var currencyIndex = 0;
        return new Faker<CurrencyGroup>().RuleFor(x => x.Id, f => Guid.NewGuid())
                                         .RuleFor(x => x.Name, f => _currencyGroupsNames[index++])
                                         .RuleFor(
                                             x => x.Currencies,
                                             f => currencies.Skip(currencyIndex++ * currencyAmount).Take(currencyAmount).ToList())
                                         .Generate(_currencyGroupsNames.Count);
    }

    private List<PaymentSystem> GeneratePaymentSystems(int currencyAmount, int amount, List<Currency> currencies) =>
        new Faker<PaymentSystem>().RuleFor(x => x.Id, f => Guid.NewGuid())
                                  .RuleFor(x => x.Name, f => f.Company.CompanyName())
                                  .RuleFor(x => x.Description, f => f.Company.CatchPhrase())
                                  .RuleFor(x => x.Currencies, f => f.PickRandom(currencies, currencyAmount).ToList())
                                  .Generate(amount);

    private List<Payment> GeneratePayments(int amount) =>
        new Faker<Payment>().RuleFor(x => x.Id, f => Guid.NewGuid())
                            .RuleFor(x => x.Name, f => f.Commerce.ProductName())
                            .RuleFor(x => x.Description, f => f.Commerce.ProductDescription())
                            .RuleFor(x => x.Amount, f => f.Finance.Amount())
                            .RuleFor(x => x.Status, f => f.PickRandom<PaymentStatus>()).Generate(amount);

    private void LinkPayments(List<PaymentSystem> paymentSystems, List<Payment> payments)
    {
        var count = payments.Count / paymentSystems.Count;
        var index = 0;
        foreach (var paymentSystem in paymentSystems)
        {
            foreach (var payment in payments.Skip(index++ * count).Take(count))
            {
                payment.Currency = paymentSystem.Currencies.ToList()[Random.Shared.Next(paymentSystem.Currencies.Count)];
                paymentSystem.Payments.Add(payment);
            }
        }
    }
}
