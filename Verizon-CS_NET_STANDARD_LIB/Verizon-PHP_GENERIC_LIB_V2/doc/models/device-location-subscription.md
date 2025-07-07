
# Device Location Subscription

*This model accepts additional fields of type array.*

## Structure

`DeviceLocationSubscription`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountName` | `?string` | Optional | Account identifier in "##########-#####". | getAccountName(): ?string | setAccountName(?string accountName): void |
| `locType` | `?string` | Optional | Location service license type. | getLocType(): ?string | setLocType(?string locType): void |
| `maxAllowance` | `?string` | Optional | The number of billable location requests allowed per billing cycle. | getMaxAllowance(): ?string | setMaxAllowance(?string maxAllowance): void |
| `purchaseTime` | `?string` | Optional | Location service purchase time. | getPurchaseTime(): ?string | setPurchaseTime(?string purchaseTime): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

