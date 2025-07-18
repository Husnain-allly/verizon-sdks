
# Security Subscription

Subscription of the device.

## Structure

`SecuritySubscription`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ExtendedAttributes` | [`List<ExtendedAttributes>`](../../doc/models/extended-attributes.md) | Optional | Attributes of the subscription.<br><br>**Constraints**: *Maximum Items*: `5` |
| `LicenseAssigned` | `int?` | Optional | The total number of licenses for this license type that are assigned to device SIMs.<br><br>**Constraints**: `>= 0`, `<= 10` |
| `LicenseAvailable` | `int?` | Optional | The total number of licenses for this license type that are available to assign to device SIMs.<br><br>**Constraints**: `>= 0`, `<= 10` |
| `LicensePurchased` | `int?` | Optional | The total number of licenses purchased for the license type.<br><br>**Constraints**: `>= 0`, `<= 10` |
| `LicenseType` | `string` | Optional | The license type associated with the skuNumber. |
| `SkuNumber` | `string` | Optional | The skuNumber that identifies the license type. |

## Example (as JSON)

```json
{
  "skuNumber": "TS-BUNDLE-KTO-SIMSEC-MRC",
  "licenseType": "Flexible Bundle",
  "licensePurchased": 9,
  "licenseAssigned": 7,
  "licenseAvailable": 1,
  "extendedAttributes": [
    {
      "key": "key8",
      "value": "value0"
    },
    {
      "key": "key8",
      "value": "value0"
    }
  ]
}
```

