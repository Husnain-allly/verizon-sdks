
# Device Location Subscription

*This model accepts additional fields of type Object.*

## Structure

`DeviceLocationSubscription`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Optional | Account identifier in "##########-#####". | String getAccountName() | setAccountName(String accountName) |
| `LocType` | `String` | Optional | Location service license type. | String getLocType() | setLocType(String locType) |
| `MaxAllowance` | `String` | Optional | The number of billable location requests allowed per billing cycle. | String getMaxAllowance() | setMaxAllowance(String maxAllowance) |
| `PurchaseTime` | `String` | Optional | Location service purchase time. | String getPurchaseTime() | setPurchaseTime(String purchaseTime) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

