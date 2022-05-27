"use strict";

let connection = new signalR.HubConnectionBuilder().withUrl("/chat/hub").configureLogging(signalR.LogLevel.Information).build();

//Disable the send button until connection is established.
document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    console.log("get")
    console.log(message);
    console.log(user);
    
    var h = document.createElement("h5");
    h.style.color = "white"
    document.getElementById("messagesList").appendChild(h);
    // We can assign user-supplied strings to an element's textContent because it
    // is not interpreted as markup. If you're assigning in any other way, you 
    // should be aware of possible script injection concerns.
    h.textContent = `${user}: ${message}`;
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
    console.log("connected")
}).catch(function (err) {
    console.log(err.toString())
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;

    console.log("send")
    console.log(message);
    console.log(user);
    connection.invoke("SendMessage", user, message).catch(function (err) {
        console.log(err.toString())
        return console.error(err.toString());
    });
    event.preventDefault();
});