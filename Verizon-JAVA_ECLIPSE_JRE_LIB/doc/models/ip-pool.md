
# Ip Pool

IP pool that is available to the account.

*This model accepts additional fields of type Object.*

## Structure

`IpPool`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `PoolName` | `String` | Optional | The name of the IP pool. | String getPoolName() | setPoolName(String poolName) |
| `PoolType` | `String` | Optional | The type of IP pool, such as “Static IP” or “Dynamic IP.” | String getPoolType() | setPoolType(String poolType) |
| `IsDefaultPool` | `Boolean` | Optional | True if this is the default IP pool for the account. | Boolean getIsDefaultPool() | setIsDefaultPool(Boolean isDefaultPool) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

