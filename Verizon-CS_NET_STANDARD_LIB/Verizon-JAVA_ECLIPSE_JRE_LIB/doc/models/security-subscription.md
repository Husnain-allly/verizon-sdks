
# Security Subscription

Subscription of the device.

## Structure

`SecuritySubscription`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `ExtendedAttributes` | [`List<ExtendedAttributes>`](../../doc/models/extended-attributes.md) | Optional | Attributes of the subscription.<br><br>**Constraints**: *Maximum Items*: `5` | List<ExtendedAttributes> getExtendedAttributes() | setExtendedAttributes(List<ExtendedAttributes> extendedAttributes) |
| `LicenseAssigned` | `Integer` | Optional | The total number of licenses for this license type that are assigned to device SIMs.<br><br>**Constraints**: `>= 0`, `<= 10` | Integer getLicenseAssigned() | setLicenseAssigned(Integer licenseAssigned) |
| `LicenseAvailable` | `Integer` | Optional | The total number of licenses for this license type that are available to assign to device SIMs.<br><br>**Constraints**: `>= 0`, `<= 10` | Integer getLicenseAvailable() | setLicenseAvailable(Integer licenseAvailable) |
| `LicensePurchased` | `Integer` | Optional | The total number of licenses purchased for the license type.<br><br>**Constraints**: `>= 0`, `<= 10` | Integer getLicensePurchased() | setLicensePurchased(Integer licensePurchased) |
| `LicenseType` | `String` | Optional | The license type associated with the skuNumber. | String getLicenseType() | setLicenseType(String licenseType) |
| `SkuNumber` | `String` | Optional | The skuNumber that identifies the license type. | String getSkuNumber() | setSkuNumber(String skuNumber) |

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

