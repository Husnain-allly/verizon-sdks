
# Create Io T Application Request

The request body must include the UUID of the subscription that you want to update plus any properties that you want to change.

*This model accepts additional fields of type array.*

## Structure

`CreateIoTApplicationRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `appName` | `?string` | Optional | A user defined name for the application being deployed in Azure IoT Central. | getAppName(): ?string | setAppName(?string appName): void |
| `billingAccountId` | `?string` | Optional | The ThingSpace ID of the authenticating billing account | getBillingAccountId(): ?string | setBillingAccountId(?string billingAccountId): void |
| `clientId` | `?string` | Optional | The Azure ClientID of the associated Azure target account | getClientId(): ?string | setClientId(?string clientId): void |
| `clientSecret` | `?string` | Optional | The Azure Client Secret of the associated Azure target account | getClientSecret(): ?string | setClientSecret(?string clientSecret): void |
| `emailIDs` | `?string` | Optional | The “email IDs” to be added to/sent to with this API. | getEmailIDs(): ?string | setEmailIDs(?string emailIDs): void |
| `resourcegroup` | `?string` | Optional | The Azure Resource group of the associated Azure target account | getResourcegroup(): ?string | setResourcegroup(?string resourcegroup): void |
| `sampleIoTcApp` | `?string` | Optional | This is the reference Azure IoT Central application developed by Verizon. | getSampleIoTcApp(): ?string | setSampleIoTcApp(?string sampleIoTcApp): void |
| `subscriptionId` | `?string` | Optional | The Azure Subscription ID of the associated Azure target account | getSubscriptionId(): ?string | setSubscriptionId(?string subscriptionId): void |
| `tenantId` | `?string` | Optional | The Azure Tenant ID of the associated Azure target account | getTenantId(): ?string | setTenantId(?string tenantId): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

