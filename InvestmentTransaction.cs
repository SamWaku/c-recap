// using FastEndpoints;
// using Microsoft.EntityFrameworkCore;
// using PatumbaPlatform.Core.Common.Pagination;
// using PatumbaPlatform.Core.Modules.Clients.Endpoints;
// using PatumbaPlatform.Core.Modules.Database;
// using PatumbaPlatform.Core.Modules.Extensions;
// using PatumbaPlatform.Core.Modules.Wallet.Models;
// using PatumbaPlatform.Core.PatumbaCore.Commands.Dashboard.Mobile;
// using PatumbaPlatform.Core.PatumbaCore.Entities;

// namespace PatumbaPlatform.Core.PatumbaCore.Endpoints.Dashboard.Mobile
// {
//     public class InvestmentTransactionsRequest : PaginationFilter
//     {
//         public String? TransactionType { get; set; }
        
//     }
    
//     public class GetIMobileDashInvestmentTransactionsEndpoints(PatumbaDatabase database) 
//         : Endpoint<InvestmentTransactionsRequest, PaginatedResponse<MobileInvestmentTransactionResponse>>

//     {
//         public override void Configure()
//         {
//             Get("patumba/dashboard/mobile-investment-transactions");
//             Summary(s =>
//             {
//                 s.Summary="Get all mobile investment transactions";
//             });
//             AllowAnonymous();
//         }

//         public override async Task<PaginatedResponse<MobileInvestmentTransactionResponse>> ExecuteAsync(
//             InvestmentTransactionsRequest filter, CancellationToken ct)
//         {
//             TransactionType? parsedTransactionType = null;
            
//             if(!string.IsNullOrEmpty(filter.TransactionType) && 
//                Enum.TryParse<TransactionType>(filter.TransactionType, out var result))
//             {
//                 parsedTransactionType = result;
//             }

//             var query = database.InvestmentTransactions
//                 .OrderByDescending(x => x.Id)
//                 .ConditionalWhere(filter.TransactionType != null, x => x.TransactionType == parsedTransactionType)
//                 .Take(100);
            
//             var investmentTransactions = await query
//                 .InvestmentTransactionsOrderAndPaginate(filter)
//                 .ToListAsync(cancellationToken: ct);
            
//             var totalItems = await query.CountAsync(cancellationToken: ct);

//             return investmentTransactions.Select(x => new MobileInvestmentTransactionResponse
//             {
//                 Id = x.Id,
//                 Account = x.Account,
//                 PaymentMethod = x.PaymentMethod,
//                 Status = x.Status,
//                 ExternalId = x.ExternalId,
//                 TransactionType = x.TransactionType,
//                 Units = x.Units,
//                 Amount = x.Amount,
//                 UnitPrice = x.UnitPrice,
//                 ProductType = x.ProductType,
//                 CreatedAt = x.CreatedAt,
//                 UpdatedAt = x.UpdatedAt
//             }).ToPagedResponse(totalItems, filter);
//         }
//     }
// }
