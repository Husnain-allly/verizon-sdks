
# Ip Pool

IP pool that is available to the account.

*This model accepts additional fields of type Any.*

## Structure

`IpPool`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `pool_name` | `str` | Optional | The name of the IP pool. |
| `pool_type` | `str` | Optional | The type of IP pool, such as “Static IP” or “Dynamic IP.” |
| `is_default_pool` | `bool` | Optional | True if this is the default IP pool for the account. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "poolName": "ACMESTATIC001",
  "poolType": "Static IP",
  "isDefaultPool": true,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

