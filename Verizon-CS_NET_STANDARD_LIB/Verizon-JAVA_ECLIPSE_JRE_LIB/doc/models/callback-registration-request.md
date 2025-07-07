
# Callback Registration Request

Specifies the callback service that is being subscribed to and the URL where the listening service is running.

*This model accepts additional fields of type Object.*

## Structure

`CallbackRegistrationRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Required | The name of the billing account for which callback messages will be sent. Format: "##########-#####". | String getAccountName() | setAccountName(String accountName) |
| `ServiceName` | `String` | Required | The name of the callback service, which identifies the type and format of messages that will be sent to the registered URL. | String getServiceName() | setServiceName(String serviceName) |
| `Endpoint` | `String` | Required | The URL for your web server. | String getEndpoint() | setEndpoint(String endpoint) |
| `HttpHeaders` | `Object` | Optional | Your HTTP headers. | Object getHttpHeaders() | setHttpHeaders(Object httpHeaders) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "accountName": "TestQAAccount",
  "serviceName": "Diagnostics",
  "endpoint": "https://yourwebsite.com",
  "httpHeaders": {
    "key1": "val1",
    "key2": "val2"
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

