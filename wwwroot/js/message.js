

var connection = new signalR.HubConnectionBuilder().withUrl("/messages").build();


connection.on("ReceiveMessage", function (message) {
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var div = document.createElement("div");
    div.innerHTML = msg + "<hr/>";
    $('#discussion').append('<p style="color:blue;text-align:right;"><strong><img = src="https://www.phplivesupport.com/pics/icons/avatars/public/avatar_71.png" title="Peter">'
        + ' </strong> ' + (message) + '</p>');
    document.getElementById("discussion").append('<p style="color:green; text-align:left; width:500px"><strong><img = src="https://www.phplivesupport.com/pics/icons/avatars/public/avatar_7.png" title="Atir">'
        + ' </strong> ' + message + '</p>');
})

connection.start().catch(function (err) {
    return console.error(err.toString());
})

connection.on("UserConnected", function (connectionId) {
    var groupElement = document.getElementById("group");
    var option = document.createElement("option");
    option.text = connectionId;
    option.value = connectionId;
    groupElement.add(option);
});

connection.on("UserDisconnected", function (connectionId) {
    var groupElement = document.getElementById("group");
    for (var i = 0; i < groupElement.length; i++) {
        if (groupElement.options[i].value == connectionId) {
            groupElement.remove(i);
        }
    }
});

document.getElementById("sendmessage").addEventListener("click", function (event) {
    var message = document.getElementById("message").value;
    var groupelement = document.getElementById("group");
    var groupValue = groupelement.options[groupelement.selectedIndex].value;
    var method = "SendMessage";
    if (groupValue == "All" || groupValue == "Myself") {
        var method = groupValue == "All" ? "SendMessage" : "SendMessageToCaller";
        connection.invoke(method, "Saba", message).catch(function (err) {
            return console.error(err.toString());
        });
    }

        else {
            connection.invoke("SendMessageToUser", groupValue, message).catch(function (err) {
                return console.error(err.toString());
        });
    }


    event.preventDefault();
});

