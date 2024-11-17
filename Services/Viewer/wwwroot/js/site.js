// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function requestControl() {
    var request;

    $('#company').on('click', function (event) {
        self.requestInfo('company')
    });
    $('#invoice').on('click', function (event) {
        self.requestInfo('invoice')
    });
    $('#item-sales').on('click', function (event) {
        self.requestInfo('itemsales')
    });
    $('#bill').on('click', function (event) {
        self.requestInfo('bill')
    });
    $('#check').on('click', function (event) {
        self.requestInfo('check')
    });

    this.requestInfo = function (sourceInfo) {
        request = sourceInfo
        var action = 'home/get' + sourceInfo + 'info';
        $("body").css("cursor", "wait");
        $.ajax({
            type: 'GET',
            url: action,
            data: null,
            dataType: "html"
        })
            .done(function (result) {
                $("body").css("cursor", "default");
                self.showInfo(result);
            })
            .fail(function (xhr, ajaxOptions, thrownError) {
                $("body").css("cursor", "default");
                var err = eval("(" + xhr.responseText + ")");
                message.Danger(err.detail);
            });
    };
    this.showInfo = function (result) {
        let info;
        if (result) {
            switch (request) {
                case 'company':
                    var company = JSON.parse(result).company;
                    info = company.QBXMLMsgsRs.CompanyQueryRs.CompanyRet.LegalCompanyName;
                    break;
                case 'invoice':
                    var invoice = JSON.parse(result).invoice;
                    info = invoice.QBXMLMsgsRs.InvoiceQueryRs.InvoiceRet.length;
                    break;
                    break;
                case 'itemsales':
                    var itemsales = JSON.parse(result).itemsales;
                    info = itemsales.QBXMLMsgsRs.ItemSalesTaxQueryRs.ItemSalesTaxRet.length;
                    break;
                case 'bill':
                    var bill = JSON.parse(result).bill;
                    info = bill.QBXMLMsgsRs.BillQueryRs.BillRet.length;
                    break;
                case 'check':
                    var check = JSON.parse(result).check;
                    info = check.QBXMLMsgsRs.CheckQueryRs.CheckRet.length;
                    break;
            }
            $('#' + request + '-info').text(info);
        }
    };

    var self = this;
}
function messageDialog() {
    $('#messageModal').on('hidden.bs.modal', function () {
        $('#messageDialog').empty();
    });
    this.Primary = function (message) {
        if (!message) return;
        $('#messageDialog').html('<div class="alert alert-primary alert-dismissible">' + message + '<button type="button" class= "btn-sm btn-close" data-bs-dismiss="modal"></button></div>');
        $("#messageModal").modal("show");
    }
    this.Secondary = function (message) {
        if (!message) return;
        $('#messageDialog').html('<div class="alert alert-secondary alert-dismissible">' + message + '<button type="button" class= "btn-sm btn-close" data-bs-dismiss="modal"></button></div>');
        $("#messageModal").modal("show");
    }
    this.Success = function (message) {
        if (!message) return;
        $('#messageDialog').html('<div class="alert alert-success alert-dismissible"><strong>Ok. </strong>' + message + '<button type="button" class= "btn-sm btn-close" data-bs-dismiss="modal"></button></div>');
        $("#messageModal").modal("show");
    }
    this.Danger = function (message) {
        if (!message) return;
        $('#messageDialog').html('<div class="alert alert-danger alert-dismissible"><strong>Error! </strong>' + message + '<button type="button" class= "btn-sm btn-close" data-bs-dismiss="modal"></button></div>');
        $("#messageModal").modal("show");
    }
    this.Warning = function (message) {
        if (!message) return;
        $('#messageDialog').html('<div class="alert alert-warning alert-dismissible"><strong>Warning! </strong>' + message + '<button type="button" class= "btn-sm btn-close" data-bs-dismiss="modal"></button></div>');
        $("#messageModal").modal("show");
    }
    this.Info = function (message) {
        if (!message) return;
        $('#messageDialog').html('<div class="alert alert-info alert-dismissible"><strong>Information. </strong>' + message + '<button type="button" class= "btn-sm btn-close" data-bs-dismiss="modal"></button></div>');
        $("#messageModal").modal("show");
    }
    this.ViewXml = function (message) {
        if (!message) return;
        $('#messageDialog').html('<div class="alert xmlview alert-dismissible">' + message + '<button type="button" class= "btn-sm btn-close" data-bs-dismiss="modal"></button></div>');
        $("#messageModal").modal("show");
    }

    var self = this;
}

const control = new requestControl();
const message = new messageDialog();

