#if !BESTHTTP_DISABLE_WEBSOCKET

using System;

using UnityEngine;
using BestHTTP;
using BestHTTP.WebSocket;
using BestHTTP.Examples;

public class TestWebsocketConnection : MonoBehaviour
{
    #region Private Fields

    /// <summary>
    /// The WebSocket address to connect
    /// </summary>
    string address = "ws://172.20.10.2:40510";

    /// <summary>
    /// Default text to send
    /// </summary>
    string msgToSend = "Hello World!";
    
    /// <summary>
    /// Saved WebSocket instance
    /// </summary>
    WebSocket webSocket;

    /// <summary>
    /// GUI scroll position
    /// </summary>
    Vector2 scrollPos;

    #endregion

    #region Unity Events

    void OnDestroy()
    {
        if (webSocket != null)
            webSocket.Close();
    }

    void Start()
    {

        // Create the WebSocket instance
        webSocket = new WebSocket(new Uri(address));

#if !UNITY_WEBGL
        webSocket.StartPingThread = true;

#if !BESTHTTP_DISABLE_PROXY
        if (HTTPManager.Proxy != null)
            webSocket.InternalRequest.Proxy = new HTTPProxy(HTTPManager.Proxy.Address, HTTPManager.Proxy.Credentials, false);
#endif
#endif

        // Subscribe to the WS events
        webSocket.OnOpen += OnOpen;
        webSocket.OnMessage += OnMessageReceived;
        webSocket.OnClosed += OnClosed;
        webSocket.OnError += OnError;

        // Start connecting to the server
        webSocket.Open();

        Debug.Log("Opening Web Socket...");
        

    }

    #endregion

    #region WebSocket Event Handlers

    /// <summary>
    /// Called when the web socket is open, and we are ready to send and receive data
    /// </summary>
    void OnOpen(WebSocket ws)
    {
        ws.Send("Hello there!");
        Debug.Log("-WebSocket Open!");
    }

    /// <summary>
    /// Called when we received a text message from the server
    /// </summary>
    void OnMessageReceived(WebSocket ws, string message)
    {
        Debug.Log("-Message received: {0}" + message);
    }

    /// <summary>
    /// Called when the web socket closed
    /// </summary>
    void OnClosed(WebSocket ws, UInt16 code, string message)
    {
        Debug.Log("-WebSocket closed! Code: "+ code + " Message: {1}\n" + message);
        webSocket = null;
    }

    /// <summary>
    /// Called when an error occured on client side
    /// </summary>
    void OnError(WebSocket ws, Exception ex)
    {
        string errorMsg = string.Empty;
#if !UNITY_WEBGL || UNITY_EDITOR
        if (ws.InternalRequest.Response != null)
            errorMsg = string.Format("Status Code from Server: {0} and Message: {1}", ws.InternalRequest.Response.StatusCode, ws.InternalRequest.Response.Message);
#endif
        if (ex == null)
        {
            Debug.Log("Unknown error: " + errorMsg);
        }
        else
        {
            Debug.Log("-An error occured: " +  ex.Message);
        }
        webSocket = null;
    }

    #endregion
}

#endif