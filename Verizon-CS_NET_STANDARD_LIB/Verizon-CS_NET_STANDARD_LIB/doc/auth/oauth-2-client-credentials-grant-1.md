
# OAuth 2 Client Credentials Grant



Documentation for accessing and setting credentials for thingspace_oauth1.

## Auth Credentials

| Name | Type | Description | Setter | Getter |
|  --- | --- | --- | --- | --- |
| OAuthClientId | `string` | OAuth 2 Client ID | `OauthClientId` | `OauthClientId` |
| OAuthClientSecret | `string` | OAuth 2 Client Secret | `OauthClientSecret` | `OauthClientSecret` |
| OAuthToken | `Models.OauthToken` | Object for storing information about the OAuth token | `OauthToken` | `OauthToken` |
| OauthClockSkew | `TimeSpan?` | Clock skew time in seconds applied while checking the OAuth Token expiry. | `OauthClockSkew` | `OauthClockSkew` |
| OauthTokenProvider | `Func<ThingspaceOauth1Manager, OauthToken, Task<OauthToken>>` | Registers a callback for oAuth Token Provider used for automatic token fetching/refreshing. | `OauthTokenProvider` | `OauthTokenProvider` |
| OauthOnTokenUpdate | `Action<OauthToken>` | Registers a callback for token update event. | `OauthOnTokenUpdate` | `OauthOnTokenUpdate` |



**Note:** Auth credentials can be set using `ThingspaceOauth1Credentials` in the client builder and accessed through `ThingspaceOauth1Credentials` method in the client instance.

## Usage Example

### Client Initialization

You must initialize the client with *OAuth 2.0 Client Credentials Grant* credentials as shown in the following code snippet. This will fetch the OAuth token automatically when any of the endpoints, requiring *OAuth 2.0 Client Credentials Grant* authentication, are called.

```csharp
VerizonClient client = new VerizonClient.Builder()
    .ThingspaceOauth1Credentials(
        new ThingspaceOauth1Model.Builder(
            "OAuthClientId",
            "OAuthClientSecret"
        )
        .Build())
    .Build();
```



Your application can also manually provide an OAuthToken using the setter `oauthToken` in `ThingspaceOauth1Model` object. This function takes in an instance of OAuthToken containing information for authorizing client requests and refreshing the token itself.

### Adding OAuth Token Update Callback

Whenever the OAuth Token gets updated, the provided callback implementation will be executed. For instance, you may use it to store your access token whenever it gets updated.

```csharp
VerizonClient client = new VerizonClient.Builder()
    .ThingspaceOauth1Credentials(
        new ThingspaceOauth1Model.Builder(
            "OAuthClientId",
            "OAuthClientSecret"
        )
        .OauthOnTokenUpdate(token => 
        {
            // It will be triggered whenever the token gets updated
            SaveTokenToDatabase(token);
        })
        .Build())
    .Build();
```

### Adding Custom OAuth Token Provider

To authorize a client using a stored access token, set up the `oauthTokenProvider` in `ThingspaceOauth1Model` builder along with the other auth parameters before creating the client:

```csharp
VerizonClient client = new VerizonClient.Builder()
    .ThingspaceOauth1Credentials(
        new ThingspaceOauth1Model.Builder(
            "OAuthClientId",
            "OAuthClientSecret"
        )
        .OauthTokenProvider(async (credentialsManager, token) =>
        {
            // Add the callback handler to provide a new OAuth token
            // It will be triggered whenever the token is undefined or expired
            return LoadTokenFromDatabase() ?? await credentialsManager.FetchTokenAsync();
        })
        .Build())
    .Build();
```


