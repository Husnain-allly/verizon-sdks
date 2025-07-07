
# Ip Pool

IP pool that is available to the account.

*This model accepts additional fields of type interface{}.*

## Structure

`IpPool`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PoolName` | `*string` | Optional | The name of the IP pool. |
| `PoolType` | `*string` | Optional | The type of IP pool, such as “Static IP” or “Dynamic IP.” |
| `IsDefaultPool` | `*bool` | Optional | True if this is the default IP pool for the account. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

