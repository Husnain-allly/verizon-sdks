
# Carrier Information

Information about the carrier.

*This model accepts additional fields of type Any.*

## Structure

`CarrierInformation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `carrier_name` | `str` | Optional | The carrier that will perform the activation. This parameter is only required if you have more than one carrier. |
| `service_plan` | `str` | Optional | The service plan code that is assigned to the device. |
| `state` | `str` | Optional | The device state. Valid values include: Activate, Suspend, Deactive, Pre-active. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

