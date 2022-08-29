// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function Veri_Listele(_url, id) {
    var table = $(`#${id}`);
    $.ajax({
        url: _url,
        method: 'GET',
        dataType: 'json',
        async: false,
        success: function (liste) {
            table.bootstrapTable('load', liste);
            table.bootstrapTable({ data: liste });
        },
        error: function (err) {
            Swal.fire({
                icon: 'error',
                title: 'Hata...',
                text: 'Sistem de Hata meydana geldi!',
            }).then((result) => {
                if (result.isConfirmed) {
                    window.location.reload();
                }
            });
            console.log(err);
        }
    });
};
function Veri_Ekle(_url, id, _data = null) {
    var frm = $('#' + id);
    if (_data == null) {
        _data = JSON.stringify(frm.serializeJSON());
    }
    $.ajax({
        url: _url,
        method: 'POST',
        data: _data,
        async: false,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (result) {
            console.log(result);
            Swal.fire(
                'Veriler Eklendi!',
                'Verileriniz başarı ile eklenmiştir!',
                'success'
            ).then((result) => {
                if (result.isConfirmed) {
                    window.location.reload();
                }
            });
        },
        error: function (err) {
            console.log(err);
            Swal.fire({
                icon: 'error',
                title: 'Hata...',
                text: 'Sistem de Hata meydana geldi!',
            }).then((result) => {
                if (result.isConfirmed) {
                }
            });
        }
    });
};
function Veri_Sil(_url, nesne) {
    var _data = JSON.stringify(nesne);
    $.ajax({
        url: _url,
        method: 'DELETE',
        dataType: 'json',
        data: _data,
        async: false,
        contentType: 'application/json; charset=utf-8',
        success: function (result) {
            Swal.fire(
                'Veriler Silindi!',
                'Veriler Başarıyla Silindi!',
                'success'
            ).then((result) => {
                if (result.isConfirmed) {
                    window.location.reload();
                }
            });
        },
        error: function (err) {
            console.log(err);
            Swal.fire({
                icon: 'error',
                title: 'Hata...',
                text: 'Sistem de Hata meydana geldi!',
            });
        }
    });
};
/*Güncelleme butonuna tıklanınca combobox lar dolu olsun diye yazıldı*/
function Veri_Getir_UserIcin(_url, data) {
    $.ajax({
        url: _url,
        method: 'GET',
        dataType: 'json',
        data: { id: data },
        async: false,
        success: function (result) {
            $('#AdGuncelle').val(result.name);
            $('#SoyadGuncelle').val(result.surname);
            $('#TelefonGuncelle').val(result.phoneNumber);
            $('#OnayGuncelle').val(result.confirmed);
        },
        error: function (err) {
            console.log(err);
            Swal.fire({
                icon: 'error',
                title: 'Hata...',
                text: 'Sistem de Hata meydana geldi!',
            });
        }
    });
};

function Veri_Guncelle(_url, nesne) {
    if (nesne != null) {
        var _data = JSON.stringify(nesne);
    }
    else {
        Swal.fire({
            icon: 'error',
            title: 'Oops...',
            text: 'Güncelleme yapılacak alan boş geldiği için Hata meydana geldi!',
        })
    }
    $.ajax({
        url: _url,
        method: 'PUT',
        data: _data,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (result) {
            Swal.fire(
                'Veriler Güncellendi!',
                'Güncelleme işlemi başarıyla gerçekleşti!',
                'success'
            ).then((result) => {
                if (result.isConfirmed) {
                    window.location.reload();
                }
            });
        },
        error: function (err) {
            console.log(err);
            Swal.fire({
                icon: 'error',
                title: 'Hata...',
                text: 'Sistem de Hata meydana geldi!',
            });
        }
    });
};