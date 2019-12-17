$(document).ready(function () {
    $('#AModaCloselBtn').click(function () {
        ClearAddTable();
    });
    $('#AModalAddBtn').click(function () {
        var _d = $('#Add_Date').val();      
        if (_d != '') {            
            AddBodyIndex();}        
        else {
            alert('日期欄位不可為空白!'); }
    });
    $('#EModalEditBtn').click(function () {
        var _d = $('#Edit_Date').val();
        if (_d != '') {
            EditBodyIndex();
        }
        else {
            alert('日期欄位不可為空白!');
        }
    });
    $('#EModaCloselBtn').click(function () {
        ClearEditTable();
    });  
});
function ClickEditBtn(elem) {
    var _Date = $(elem).parents("tr").find("th").eq(0).text();
    var _Weight = $(elem).parents("tr").find("td").eq(0).text();
    var _BMI = $(elem).parents("tr").find("td").eq(1).text();
    var _BodyFat = $(elem).parents("tr").find("td").eq(2).text();
    var _SkeletalMuscleRate = $(elem).parents("tr").find("td").eq(3).text();
    var _VisceralFat = $(elem).parents("tr").find("td").eq(4).text();
    $('#EditModal').modal('toggle');
    $('#Edit_Date').val(_Date);
    $('#Edit_Weight').val(_Weight);
    $('#Edit_BMI').val(_BMI);
    $('#Edit_BodyFat').val(_BodyFat);
    $('#Edit_SkeletalMuscleRate').val(_SkeletalMuscleRate);
    $('#Edit_VisceralFat').val(_VisceralFat);
}
function ClickDelBtn(elem) {
   
    var _Date = $(elem).parents("tr").find("th").eq(0).text();
    var _confrim = confirm('確定要刪除' + _Date + ' 的資料嗎?')

    if (_confrim) { DelBodyIndex(_Date); }   
}

function AddBodyIndex() {
    
    $.ajax({
        url: "/BodyIndex/AddBodyIndex",
        dataType: "json",
        type: "post",
        async: false,
        data: {
            "ID": "201900001", //$('#ID').val(),
            "Date": $('#Add_Date').val(),
            "Weight": $('#Add_Weight').val(),
            "BMI": $('#Add_BMI').val(),
            "BodyFat": $('#Add_BodyFat').val(),
            "SkeletalMuscleRate": $('#Add_SkeletalMuscleRate').val(),
            "VisceralFat": $('#Add_VisceralFat').val()
        },

        success: function (result) {
            ClearAddTable();
            //清除
           RefreshTable();
        },
        error: function () {
            alert('新增資料出現錯誤!');
        }
    }) 
}
function EditBodyIndex() {

    $.ajax({
        url: "/BodyIndex/EditBodyIndex",
        dataType: "json",
        type: "post",
        async: false,
        data: {
            "ID": "201900001", //$('#ID').val(),
            "Date":$('#Edit_Date').val(),
            "Weight": $('#Edit_Weight').val(),
            "BMI": $('#Edit_BMI').val(),
            "BodyFat": $('#Edit_BodyFat').val(),
            "SkeletalMuscleRate": $('#Edit_SkeletalMuscleRate').val(),
            "VisceralFat": $('#Edit_VisceralFat').val()
        },

        success: function (result) {
            ClearEditTable();
            
            RefreshTable();
        },
        error: function () {
            alert('修改資料出現錯誤!');
        }
    })
}
function DelBodyIndex(_Date) {

    $.ajax({
        url: "/BodyIndex/DelBodyIndex",
        dataType: "json",
        type: "post",
        async: false,
        data: {
            "ID": "201900001", //$('#ID').val(),
            "Date": _Date
            
        },

        success: function (result) {
            

            RefreshTable();
        },
        error: function () {
            alert('刪除資料出現錯誤!');
        }
    })
}
function RefreshTable() {
    $.ajax({
        url: "/BodyIndex/BodyIndexTable",

        dataType: "html",
        contentType: "application/html; charset=utf-8",
        type: "get",
        async: false,
        success: function (result) {

            $('#BodyIndexTable').html(result);
            //新增完成
        },
        error: function () {
            alert('表單刷新出現錯誤!');
        }
    })
}
function ClearAddTable() {

    $('#Add_Date').val('');
    $('#Add_Weight').val('');
    $('#Add_BMI').val('');
    $('#Add_BodyFat').val('');
    $('#Add_SkeletalMuscleRate').val('');
    $('#Add_VisceralFat').val('');
}
function ClearEditTable() {

    $('#Edit_Date').val('');
    $('#Edit_Weight').val('');
    $('#Edit_BMI').val('');
    $('#Edit_BodyFat').val('');
    $('#Edit_SkeletalMuscleRate').val('');
    $('#Edit_VisceralFat').val('');
}