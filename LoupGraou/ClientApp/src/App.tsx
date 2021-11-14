import React, { useState, useEffect } from "react";
import logo from "./logo.svg";
import * as signalR from "@microsoft/signalr";
import "./App.css";

interface IMessage{
  username: string;
  message: string;
}

function App() {
  const [message, setMessage] = useState<string>("");
  const [messages, setMessages] = useState<Array<IMessage>>(new Array());
  const [connection, setConnection] = useState<null | signalR.HubConnection>(null);
  useEffect(() => {
    const connect = new signalR.HubConnectionBuilder()
      .withUrl("/api/charHub")
      .withAutomaticReconnect()
      .build();

    setConnection(connect);
  },[])
  const username = new Date().getTime();
  const send = () => {
    console.log(connection?.state)
    if(connection &&connection.state==="Connected")
      connection.send("newMessage", username, message).then(() => setMessage(""));
  }
  useEffect(() => {
    if(connection)
      connection.start().then(() => {
        connection.on("messageReceived", (username: string, message: string) => {
          var swap = messages.slice();
          swap.push({username: username, message: message} as IMessage)
          setMessages(swap);
        });
    }).catch(err => console.log(err));
  },[connection])
  return (
    <div className="App">
      <div id="divMessages" className="messages">
        {messages.map(({username,message},index)=><div key={index}><div className="message-author">{username}</div><div>{message}</div></div>)}
      </div>
      <div className="input-zone">
        <label id="lblMessage" htmlFor="tbMessage">
          Message:
        </label>
        <input
          id="tbMessage"
          className="input-zone-input"
          type="text"
          value={message}
          onChange={(e) => setMessage(e.target.value)}
        />
        <button onClick={send} id="btnSend">Send</button>
      </div>
    </div>
  );
}

export default App;
