using System.Threading.Tasks;

namespace ABCS.Test.Infrastructure
{
    public interface ICommunication
    {
        Task<(CompanyInfo info, string error)> GetCompanyInfoAsync();
        Task<(InvoiceInfo info, string error)> GetInvoiceInfoAsync();
        Task<(ItemSalesInfo info, string error)> GetItemSalesInfoAsync();
        Task<(BillInfo info, string error)> GetBillInfoAsync();
        Task<(CheckInfo info, string error)> GetCheckInfoAsync();
    }
}
