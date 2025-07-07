
# Connectivity Management Callback

Includes callback listeners that were registered through the Connectivity Management API.

*This model accepts additional fields of type Object.*

## Structure

`ConnectivityManagementCallback`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Optional | The name of the billing account for which callback messages will be sent. | String getAccountName() | setAccountName(String accountName) |
| `Password` | `String` | Optional | The password defined when a URL was registered for the callback service, or an empty string if no password was defined. | String getPassword() | setPassword(String password) |
| `ServiceName` | `String` | Optional | The name of the callback service, which identifies the type and format of messages that will be sent to the registered URL. | String getServiceName() | setServiceName(String serviceName) |
| `Url` | `String` | Optional | The address of the callback listening service where the ThingSpace Platform will send callback messages for the service type. | String getUrl() | setUrl(String url) |
| `Username` | `String` | Optional | The username defined when a URL was registered for the callback service, or an empty string if no username was defined. | String getUsername() | setUsername(String username) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "accountName": "0252012345-00001",
  "password": "drowssap",
  "serviceName": "DeviceUsage",
  "url": "http://10.120.102.147:50569/CallbackListener/Usage.asmx",
  "username": "zaffod",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

