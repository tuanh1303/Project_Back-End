var cart = {
    init: function () {
        cart.regEvents();
    },
    regEvents: function () {
        $('#btnContinue').off('click').on('click', function () {
            window.location.href = "/";
        });

        $('#btnPayment').off('click').on('click', function () {
            window.location.href = "/Giohang/payment";
        });

        $('#btnUpdate').off('click').on('click', function () {
            var listSP = $('.txtSoLuong');
            var cartList = [];
            $.each(listSP, function (i, item) {
                cartList.push({
                    SoLuong: $(item).val(),
                    SanPham: {
                        MaSP: $(item).data('MaSP')//masp,maSP
                    }
                });
            });

            $.ajax({
                url: '/GioHang/Update',
                data: { cartModel: JSON.stringify(cartList) },
                dataType: 'json',
                type: 'POST',
                success: function (res) {
                    if (res.status == true) {
                        window.location.href = "/GioHang";//Giohang,gio-hang
                    }
                }
            })
        });

        $('#btnDeleteAll').off('click').on('click', function () {

            $.ajax({
                url: '/GioHang/DeleteAll',
                dataType: 'json',
                type: 'POST',
                success: function (res) {
                    if (res.status == true) {
                        window.location.href = "/GioHang";
                    }
                }
            })
        });


        $('.btn-delete').off('click').on('click', function (e) {
            e.preventDefault();
            $.ajax({
                data: { id: $(this).data('id') },
                url: '/GioHang/Delete',
                dataType: 'json',
                type: 'POST',
                success: function (res) {
                    if (res.status == true) {
                        window.location.href = "/GioHang";
                    }
                }
            })
        });

    }
}
cart.init();