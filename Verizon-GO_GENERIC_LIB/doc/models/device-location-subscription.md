
# Device Location Subscription

*This model accepts additional fields of type interface{}.*

## Structure

`DeviceLocationSubscription`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `*string` | Optional | Account identifier in "##########-#####". |
| `LocType` | `*string` | Optional | Location service license type. |
| `MaxAllowance` | `*string` | Optional | The number of billable location requests allowed per billing cycle. |
| `PurchaseTime` | `*string` | Optional | Location service purchase time. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "2024009649-00001",
  "locType": "TS-LOC-COARSE-CellID-5K",
  "maxAllowance": "5000",
  "purchaseTime": "2017-05-10 06:25:25.171 +0000 UTC",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

