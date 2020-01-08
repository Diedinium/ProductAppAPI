var uri = "api/product"

$(function () {
    // Populates list on page load
    $.getJSON(uri).done(function (data) {
        $.each(data, function (key, item) {
            $('<li>', { text: formatItem(item) }).appendTo($("#products"));
        });
    });
    $("button[type='reset']").click(function () {
        $("#product").html("");
    });
});

// Formats item for displaying.
function formatItem(item) {
    return item.Name + ': $' + item.Price + " - Category : " + item.Category;
}

// Returns single result
function find() {
    var id = $("#prodID").val();
    $.getJSON(uri + "/" + id)
        .done(function (data) {
            $("#product").text(formatItem(data));
        })
        .fail(function (jqXHR, textStatus, err) {
            $("#product").text("Error: " + err);
        });

}