
# OAuth 2 Client Credentials Grant



Documentation for accessing and setting credentials for thingspace_oauth1.

## Auth Credentials

| Name | Type | Description | Setter | Getter |
|  --- | --- | --- | --- | --- |
| OAuthClientId | `string` | OAuth 2 Client ID | `oauthClientId` | `getOauthClientId()` |
| OAuthClientSecret | `string` | OAuth 2 Client Secret | `oauthClientSecret` | `getOauthClientSecret()` |
| OAuthToken | `OauthToken\|null` | Object for storing information about the OAuth token | `oauthToken` | `getOauthToken()` |
| OAuthClockSkew | `int` | Clock skew time in seconds applied while checking the OAuth Token expiry. | `oauthClockSkew` | - |
| OAuthTokenProvider | `callable(OauthToken, ThingspaceOauth1Manager): OauthToken` | Registers a callback for oAuth Token Provider used for automatic token fetching/refreshing. | `oauthTokenProvider` | - |
| OAuthOnTokenUpdate | `callable(OauthToken): void` | Registers a callback for token update event. | `oauthOnTokenUpdate` | - |



**Note:** Auth credentials can be set using `ThingspaceOauth1CredentialsBuilder::init()` in `thingspaceOauth1Credentials` method in the client builder and accessed through `getThingspaceOauth1Credentials` method in the client instance.

## Usage Example

### Client Initialization

You must initialize the client with *OAuth 2.0 Client Credentials Grant* credentials as shown in the following code snippet. This will fetch the OAuth token automatically when any of the endpoints, requiring *OAuth 2.0 Client Credentials Grant* authentication, are called.

```php
use VerizonLib\Authentication\ThingspaceOauth1CredentialsBuilder;
use VerizonLib\VerizonClientBuilder;

$client = VerizonClientBuilder::init()
    ->thingspaceOauth1Credentials(
        ThingspaceOauth1CredentialsBuilder::init(
            'OAuthClientId',
            'OAuthClientSecret'
        )
    )
    ->build();
```



Your application can also manually provide an OAuthToken using the setter `oauthToken` in `ThingspaceOauth1CredentialsBuilder` object. This function takes in an instance of OAuthToken containing information for authorizing client requests and refreshing the token itself.

### Adding OAuth Token Update Callback

Whenever the OAuth Token gets updated, the provided callback implementation will be executed. For instance, you may use it to store your access token whenever it gets updated.

```php
use VerizonLib\Authentication\ThingspaceOauth1CredentialsBuilder;
use VerizonLib\VerizonClientBuilder;

$client = VerizonClientBuilder::init()
    ->thingspaceOauth1Credentials(
        ThingspaceOauth1CredentialsBuilder::init(
            'OAuthClientId',
            'OAuthClientSecret'
        )
            ->oauthOnTokenUpdate(
                function (OauthToken $oAuthToken): void {
                    // Add the callback handler to perform operations like save to DB or file etc.
                    // It will be triggered whenever the token gets updated.
                    $this->saveTokenToDatabase($oAuthToken);
                }
            )
    )
    ->build();
```

### Adding Custom OAuth Token Provider

To authorize a client using a stored access token, set up the `oauthTokenProvider` in `ThingspaceOauth1CredentialsBuilder` along with the other auth parameters before creating the client:

```php
use VerizonLib\Authentication\ThingspaceOauth1CredentialsBuilder;
use VerizonLib\VerizonClientBuilder;

$client = VerizonClientBuilder::init()
    ->thingspaceOauth1Credentials(
        ThingspaceOauth1CredentialsBuilder::init(
            'OAuthClientId',
            'OAuthClientSecret'
        )
            ->oauthTokenProvider(
                function (?OauthToken $lastOAuthToken, ThingspaceOauth1Manager $authManager): OAuthToken {
                    // Add the callback handler to provide a new OAuth token.
                    // It will be triggered whenever the lastOAuthToken is null or expired.
                    return $this->loadTokenFromDatabase() ?? $authManager->fetchToken();
                }
            )
    )
    ->build();
```


