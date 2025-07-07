
# Custom Header Signature



Documentation for accessing and setting credentials for VZ-M2M-Token.

## Auth Credentials

| Name | Type | Description | Setter | Getter |
|  --- | --- | --- | --- | --- |
| VZ-M2M-Token | `string` | M2M Session Token ([How to generate an M2M session token?](../../doc/controllers/session-management.md#start-connectivity-management-session)) | `VzM2MToken` | `VzM2MToken` |



**Note:** Auth credentials can be set using `VzM2MTokenCredentials` in the client builder and accessed through `VzM2MTokenCredentials` method in the client instance.

## Usage Example

### Client Initialization

You must provide credentials in the client as shown in the following code snippet.

```csharp
VerizonClient client = new VerizonClient.Builder()
    .VzM2MTokenCredentials(
        new VzM2MTokenModel.Builder(
            "VZ-M2M-Token"
        )
        .Build())
    .Build();
```


