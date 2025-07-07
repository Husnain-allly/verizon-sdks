
# Carrier Information

Information about the carrier.

*This model accepts additional fields of type object.*

## Structure

`CarrierInformation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CarrierName` | `string` | Optional | The carrier that will perform the activation. This parameter is only required if you have more than one carrier. |
| `ServicePlan` | `string` | Optional | The service plan code that is assigned to the device. |
| `State` | `string` | Optional | The device state. Valid values include: Activate, Suspend, Deactive, Pre-active. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "carrierName": "Verizon Wireless",
  "servicePlan": "m2m4G",
  "state": "active",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

