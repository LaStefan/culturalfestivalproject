function addToCart(el) {

    var postData = {
        "name": el.name
    };

    $.ajax({
        type: "POST",
        url: '/backend/components/checkout/add_to_cart.php',
        data: postData,
        success: function(data) {
            console.log(data);
        },
        dataType: 'json'
    });
}


function addToCart(el) {

    console.log(el.name);

    var postData = {
        "name": el.name
    };

    $.ajax({
        type: "POST",
        url: '/backend/components/checkout/add_to_cart.php',
        data: postData,
        success: function(data) {
            console.log(data);
        },
        dataType: 'json'
    });
}