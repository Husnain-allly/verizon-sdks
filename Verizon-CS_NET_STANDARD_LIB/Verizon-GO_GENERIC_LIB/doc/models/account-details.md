
# Account Details

*This model accepts additional fields of type interface{}.*

## Structure

`AccountDetails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `*string` | Optional | The numeric name of the account, in the format "0000123456-00001". Leading zeros must be included.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9-]{3,32}$` |
| `AccountNumber` | `*string` | Optional | The numeric name of the account, in the format "0000123456-00001". Leading zeros must be included.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9-]{3,32}$` |
| `OrganizationName` | `*string` | Optional | user defined name of organization<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9]{3,32}$` |
| `IsProvisioningAllowed` | `*bool` | Optional | Flag set to indicate if account details can be edited or not. Default is "true". |
| `Carriers` | [`[]models.Carrier`](../../doc/models/carrier.md) | Optional | - |
| `Features` | [`[]models.Feature`](../../doc/models/feature.md) | Optional | - |
| `ServicePlans` | [`[]models.CarrierServicePlan`](../../doc/models/carrier-service-plan.md) | Optional | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "accountNumber": "0000123456-00001",
  "organizationName": "organizationName2",
  "isProvisioningAllowed": false,
  "carriers": [
    {
      "carriers": "carriers0",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "carriers": "carriers0",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "carriers": "carriers0",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

