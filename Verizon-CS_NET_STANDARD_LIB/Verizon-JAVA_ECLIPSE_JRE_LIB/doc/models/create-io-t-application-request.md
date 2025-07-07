
# Create Io T Application Request

The request body must include the UUID of the subscription that you want to update plus any properties that you want to change.

*This model accepts additional fields of type Object.*

## Structure

`CreateIoTApplicationRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AppName` | `String` | Optional | A user defined name for the application being deployed in Azure IoT Central. | String getAppName() | setAppName(String appName) |
| `BillingAccountId` | `String` | Optional | The ThingSpace ID of the authenticating billing account | String getBillingAccountId() | setBillingAccountId(String billingAccountId) |
| `ClientId` | `String` | Optional | The Azure ClientID of the associated Azure target account | String getClientId() | setClientId(String clientId) |
| `ClientSecret` | `String` | Optional | The Azure Client Secret of the associated Azure target account | String getClientSecret() | setClientSecret(String clientSecret) |
| `EmailIDs` | `String` | Optional | The “email IDs” to be added to/sent to with this API. | String getEmailIDs() | setEmailIDs(String emailIDs) |
| `Resourcegroup` | `String` | Optional | The Azure Resource group of the associated Azure target account | String getResourcegroup() | setResourcegroup(String resourcegroup) |
| `SampleIoTcApp` | `String` | Optional | This is the reference Azure IoT Central application developed by Verizon. | String getSampleIoTcApp() | setSampleIoTcApp(String sampleIoTcApp) |
| `SubscriptionId` | `String` | Optional | The Azure Subscription ID of the associated Azure target account | String getSubscriptionId() | setSubscriptionId(String subscriptionId) |
| `TenantId` | `String` | Optional | The Azure Tenant ID of the associated Azure target account | String getTenantId() | setTenantId(String tenantId) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "appName": "newarmapp1",
  "billingAccountID": "0000123456-00001",
  "clientID": "UUID",
  "clientSecret": "client secret",
  "emailIDs": "email@domain.com",
  "resourcegroup": "Myresourcegroup",
  "sampleIOTcApp": "app ID",
  "subscriptionID": "subscription ID",
  "tenantID": "tenant ID",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

