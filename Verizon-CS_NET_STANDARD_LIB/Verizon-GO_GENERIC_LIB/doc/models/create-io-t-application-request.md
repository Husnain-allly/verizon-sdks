
# Create Io T Application Request

The request body must include the UUID of the subscription that you want to update plus any properties that you want to change.

*This model accepts additional fields of type interface{}.*

## Structure

`CreateIoTApplicationRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AppName` | `*string` | Optional | A user defined name for the application being deployed in Azure IoT Central. |
| `BillingAccountId` | `*string` | Optional | The ThingSpace ID of the authenticating billing account |
| `ClientId` | `*string` | Optional | The Azure ClientID of the associated Azure target account |
| `ClientSecret` | `*string` | Optional | The Azure Client Secret of the associated Azure target account |
| `EmailIDs` | `*string` | Optional | The “email IDs” to be added to/sent to with this API. |
| `Resourcegroup` | `*string` | Optional | The Azure Resource group of the associated Azure target account |
| `SampleIoTcApp` | `*string` | Optional | This is the reference Azure IoT Central application developed by Verizon. |
| `SubscriptionId` | `*string` | Optional | The Azure Subscription ID of the associated Azure target account |
| `TenantId` | `*string` | Optional | The Azure Tenant ID of the associated Azure target account |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

