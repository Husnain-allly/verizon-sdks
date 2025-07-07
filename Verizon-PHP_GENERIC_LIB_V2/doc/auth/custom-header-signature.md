
# Custom Header Signature



Documentation for accessing and setting credentials for VZ-M2M-Token.

## Auth Credentials

| Name | Type | Description | Setter | Getter |
|  --- | --- | --- | --- | --- |
| VZ-M2M-Token | `string` | M2M Session Token ([How to generate an M2M session token?](../../doc/controllers/session-management.md#start-connectivity-management-session)) | `vzM2MToken` | `getVzM2MToken()` |



**Note:** Auth credentials can be set using `VzM2MTokenCredentialsBuilder::init()` in `vzM2MTokenCredentials` method in the client builder and accessed through `getVzM2MTokenCredentials` method in the client instance.

## Usage Example

### Client Initialization

You must provide credentials in the client as shown in the following code snippet.

```php
use VerizonLib\Authentication\VzM2MTokenCredentialsBuilder;
use VerizonLib\VerizonClientBuilder;

$client = VerizonClientBuilder::init()
    ->vzM2MTokenCredentials(
        VzM2MTokenCredentialsBuilder::init(
            'VZ-M2M-Token'
        )
    )
    ->build();
```


