
# Move Device Request

Request to move active devices from one billing account to another within a customer profile.

*This model accepts additional fields of type Any.*

## Structure

`MoveDeviceRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `str` | Required | The name of the billing account that you want to move the devices to. |
| `filter` | [`DeviceFilter`](../../doc/models/device-filter.md) | Optional | Specify the kind of the device identifier, the type of match, and the string that you want to match. |
| `custom_fields` | [`List[CustomFields]`](../../doc/models/custom-fields.md) | Optional | Custom field names and values, if you want to only include devices that have matching values. |
| `devices` | [`List[AccountDeviceList]`](../../doc/models/account-device-list.md) | Optional | Up to 10,000 devices that you want to move to a different account, specified by device identifier. |
| `group_name` | `str` | Optional | The name of a device group, to only include devices in that group. |
| `carrier_ip_pool_name` | `str` | Optional | The pool from which device IP addresses will be derived in the new account. If you do not include this element, the default pool will be used. |
| `service_plan` | `str` | Optional | The service plan code that you want to assign to the devices in the new account. If you do not include this element, ThingSpace will attempt to use the current service plan, which will result in a error if the new account does not have that service plan. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "filter": {
    "groupName": "Short-Haul Trucks",
    "customFields": [
      {
        "key": "CustomField1",
        "value": "East Region Trucks",
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      }
    ],
    "account": "account4",
    "servicePlan": "servicePlan6",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "accountName": "0212345678-00001",
  "servicePlan": "M2M5GB",
  "customFields": [
    null
  ],
  "devices": [
    null,
    {},
    {}
  ],
  "groupName": "groupName2",
  "carrierIpPoolName": "carrierIpPoolName0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

