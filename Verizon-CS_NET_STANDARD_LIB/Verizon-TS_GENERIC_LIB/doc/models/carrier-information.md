
# Carrier Information

Information about the carrier.

*This model accepts additional fields of type unknown.*

## Structure

`CarrierInformation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `carrierName` | `string \| undefined` | Optional | The carrier that will perform the activation. This parameter is only required if you have more than one carrier. |
| `servicePlan` | `string \| undefined` | Optional | The service plan code that is assigned to the device. |
| `state` | `string \| undefined` | Optional | The device state. Valid values include: Activate, Suspend, Deactive, Pre-active. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

