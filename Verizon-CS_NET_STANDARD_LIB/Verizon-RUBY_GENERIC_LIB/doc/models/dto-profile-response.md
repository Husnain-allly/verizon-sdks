
# Dto Profile Response

*This model accepts additional fields of type Object.*

## Structure

`DtoProfileResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `String` | Optional | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `kind` | `String` | Optional | the user defined profile kind |
| `version` | `String` | Optional | The resource version |
| `versionid` | `String` | Optional | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9\-_]+$` |
| `createdon` | `DateTime` | Optional | Timestamp of the record |
| `lastupdated` | `DateTime` | Optional | Timestamp of the record |
| `name` | `String` | Optional | user defined profile name |
| `foreignid` | `String` | Optional | UUID of the ECPD account the user belongs to |
| `billingaccountid` | `String` | Optional | The billing account ID. This is the same value as the Account ID |
| `modelid` | `String` | Optional | device model id |
| `configuration` | `Object` | Optional | - |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "id": "cb4169ec-eeee-ffff-gggg-d2951060421a",
  "kind": "the kind of profile being created",
  "version": "1.0",
  "versionid": "15bd78a1-eeee-ffff-gggg-86daa842009b",
  "createdon": "10/02/2023 15:46:34",
  "lastupdated": "10/02/2023 15:46:34",
  "name": "Demo Entry sensor 1730928792",
  "foreignid": "c1f178d3-eeee-ffff-gggg-0d6b7ae6022a",
  "billingaccountid": "0000123456-00001",
  "modelid": "00000000-0000-0000-0000-000000000019",
  "configuration": {
    "randomInt": 21,
    "resportingInterval": 24
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

