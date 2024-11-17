using System;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using ABCS.Test.Infrastructure;
using ABCS.Test.Module.Communication.Helpers;
using ABCS.Test.Module.Communication.Properties;
using Interop.QBXMLRP2;

namespace ABCS.Test.Module.Communication.Services
{
    internal sealed class CommunicationService(RequestProcessor2 _service) : ICommunication
    {
        #region Методы
        #region Интерфейс ICommunication
        public async Task<(BillInfo info, string error)> GetBillInfoAsync()
        {
            string bill = Encoding.Default.GetString((byte[])Resources.ResourceManager.GetObject("BillRequest", CultureInfo.InvariantCulture));
            return await Task.FromResult(Request<BillInfo>(bill)).ConfigureAwait(false);
        }
        public async Task<(CheckInfo info, string error)> GetCheckInfoAsync()
        {
            string check = Encoding.Default.GetString((byte[])Resources.ResourceManager.GetObject("CheckRequest", CultureInfo.InvariantCulture));
            return await Task.FromResult(Request<CheckInfo>(check)).ConfigureAwait(false);
        }
        public async Task<(CompanyInfo info, string error)> GetCompanyInfoAsync()
        {
            string company = Encoding.Default.GetString((byte[])Resources.ResourceManager.GetObject("CompanyRequest", CultureInfo.InvariantCulture));
            return await Task.FromResult(Request<CompanyInfo>(company)).ConfigureAwait(false);
        }
        public async Task<(InvoiceInfo info, string error)> GetInvoiceInfoAsync()
        {
            string invoice = Encoding.Default.GetString((byte[])Resources.ResourceManager.GetObject("InvoiceRequest", CultureInfo.InvariantCulture));
            return await Task.FromResult(Request<InvoiceInfo>(invoice)).ConfigureAwait(false);
        }
        public async Task<(ItemSalesInfo info, string error)> GetItemSalesInfoAsync()
        {
            string itemSales = Encoding.Default.GetString((byte[])Resources.ResourceManager.GetObject("ItemSalesRequest", CultureInfo.InvariantCulture));
            return await Task.FromResult(Request<ItemSalesInfo>(itemSales)).ConfigureAwait(false);
        }
        #endregion
        private (T, string error) Request<T>(string inputRequest) where T : class
        {
            try
            {
                QBXMLRPConnectionType connType = QBXMLRPConnectionType.localQBD;
                _service.OpenConnection2("", "ABCS.Test.Module.Communication", connType);
                string ticket = _service.BeginSession("", QBFileMode.qbFileOpenDoNotCare);
                string response = _service.ProcessRequest(ticket, inputRequest);
                T info = response.ToInstance<T>();
                _service.EndSession(ticket);
                _service.CloseConnection();
                return (info, default);
            }
            catch (Exception ex)
            {
                return (default, $"Could not start QuickBooks.\n\n");
            }
        }
        #endregion
    }
}
