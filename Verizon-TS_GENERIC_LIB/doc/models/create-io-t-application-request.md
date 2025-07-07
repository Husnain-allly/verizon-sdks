
# Create Io T Application Request

The request body must include the UUID of the subscription that you want to update plus any properties that you want to change.

*This model accepts additional fields of type unknown.*

## Structure

`CreateIoTApplicationRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `appName` | `string \| undefined` | Optional | A user defined name for the application being deployed in Azure IoT Central. |
| `billingAccountId` | `string \| undefined` | Optional | The ThingSpace ID of the authenticating billing account |
| `clientId` | `string \| undefined` | Optional | The Azure ClientID of the associated Azure target account |
| `clientSecret` | `string \| undefined` | Optional | The Azure Client Secret of the associated Azure target account |
| `emailIDs` | `string \| undefined` | Optional | The “email IDs” to be added to/sent to with this API. |
| `resourcegroup` | `string \| undefined` | Optional | The Azure Resource group of the associated Azure target account |
| `sampleIoTcApp` | `string \| undefined` | Optional | This is the reference Azure IoT Central application developed by Verizon. |
| `subscriptionId` | `string \| undefined` | Optional | The Azure Subscription ID of the associated Azure target account |
| `tenantId` | `string \| undefined` | Optional | The Azure Tenant ID of the associated Azure target account |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

