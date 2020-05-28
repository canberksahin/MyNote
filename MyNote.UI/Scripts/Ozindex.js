// GLOBAL VARİABLES
var apiUrl = "https://localhost:44305/";

//FUNCTİONS

function checkLogin() {
    // todo: sessionstorage ve localstorage da tutulan login bilgilerine bakarak
    // login olup olmadığına karar ver ve eğer logins uygulamayı aç
    // login değilse login/register sayfasını göster
    var loginData = getLoginData();

    if (!loginData || !loginData.access_token) {
        showLoginPage();
        return;
    }
    //Is Token valid?
    ajax("api/Account/UserInfo", "GET",
        function (data) {
            showAppPage();
        },
        function () {
            showLoginPage();
        });
}

function showAppPage() {
    $(".only-logged-out").hide();
    $(".only-logged-in").show();
    $(".page").hide();

    // retrieve the notes
    ajax("api/Notes/List", "GET",
        function (data) {
            console.log(data);

            $("#notes").html("");
            for (var i = 0; i < data.length; i++) {
                var a = $("<a/>")
                    .attr("href","#")
                    .addClass("list-group-item list-group-item-action show-note")
                    .text(data[i].Title)
                    .prop("note",data[i]);
                $("#notes").append(a);    
            }

            //show page when it's ready..
            $("#page-app").show();
        },
        function () {

        });
}

function getLoginData() {
    // sessionstorage da, eğer orada bulamadıysan
    // localstorage da kayıtlı login data yı json'dan object'e dönüştür ve yolla
    // eğer yoksa null yolla
    var json = sessionStorage["login"] || localStorage["login"];
    if (json) {
        try {
            return JSON.parse(json);
        } catch (e) {
            return null;
        }
    }

}

function showLoginPage() {
    $(".only-logged-in").hide();
    $(".only-logged-out").show();
    $(".page").hide();
    $("#page-login").show();
}

function getAuthorizationHeader() {
    return { Authorization: "Bearer " + getLoginData().access_token };
}

function success(message) {
    $(".tab-pane.active .message")
        .removeClass("alert-danger")
        .addClass("alert-success")
        .text(message)
        .show();
}

function error(modelState) {
    if (modelState) {
        var errors = [];
        for (var prop in modelState) {
            for (var i = 0; i < modelState[prop].length; i++) {
                errors.push(modelState[prop][i]);
            }
        }

        var ul = $("<ul/>");
        for (var i = 0; i < errors.length; i++) {
            ul.append($("<li/>").text(errors[i]));
        }
        $(".tab-pane.active .message")
            .removeClass("alert-success")
            .addClass("alert-danger")
            .html(ul)
            .show();
    }
}

function resetLoginForms() {
    $(".message").hide();
    $("#login form").each(function () {
        this.reset();
    });
}

function errorMessage(message) {
    if (message) {
        $(".tab-pane.active .message")
            .removeClass("alert-success")
            .addClass("alert-danger")
            .text(message)
            .show();
    }
}

function ajax(url, type, successFunc, errorFunc) {
    $.ajax({
        url: apiUrl + url,
        type: type,
        headers: getAuthorizationHeader(),
        success: successFunc,
        error: errorFunc
    });
}

// EVENTS

$(document).ajaxStart(function () {
    $(".loading").removeClass("d-none");
});

$(document).ajaxStop(function () {
    $(".loading").addClass("d-none");
});

$("#signupform").submit(function (event) {
    event.preventDefault();
    var formData = $(this).serialize();

    $.post(apiUrl + "api/Account/Register", formData, function (data) {
        resetLoginForms();
        success("Your account has been successfully created.");
    }).fail(function (xhr) {
        error(xhr.responseJSON.ModelState);
    });

});

$("#signinform").submit(function (event) {
    event.preventDefault();
    var formData = $(this).serialize();

    $.post(apiUrl + "Token", formData, function (data) {

        var datastr = JSON.stringify(data);
        if ($("#signinrememberme").prop("checked")) {
            sessionStorage.removeItem("login");
            localStorage["login"] = datastr;
        } else {
            sessionStorage["login"] = datastr;
        }

        resetLoginForms();
        success("You have been logged in successfully. Redirecting...");
        checkLogin();

        setTimeout(function () {
            resetLoginForms();
            showAppPage();
        }, 1000);

    }).fail(function (xhr) {
        errorMessage(xhr.responseJSON.error_description);
    });

});

// https://getbootstrap.com/docs/4.0/components/navs/#events
$('#login a[data-toggle="pill"]').on('shown.bs.tab', function (e) {
    // e.target // newly activated tab
    // e.relatedTarget // previous active tab

    resetLoginForms();
});

$(".navbar-login a").click(function (event) {
    event.preventDefault();
    var href = $(this).attr("href");

    //https://getbootstrap.com/docs/4.0/components/navs/#via-javascript
    $('#pills-tab a[href="' + href + '"]').tab('show') // Select tab by name

});

$("#btnLogout").click(function (event) {
    event.preventDefault();
    sessionStorage.removeItem["login"];
    localStorage.removeItem["login"];
    showLoginPage();
});

$("body").on("click", ".show-note", function (event) {
    event.preventDefault();
    var note = this.note;
    $("#content").val(note.Content);
    $("#title").val(note.Title);
});

// ACTİONS
checkLogin();
