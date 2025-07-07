
# Ip Pool

IP pool that is available to the account.

*This model accepts additional fields of type array.*

## Structure

`IpPool`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `poolName` | `?string` | Optional | The name of the IP pool. | getPoolName(): ?string | setPoolName(?string poolName): void |
| `poolType` | `?string` | Optional | The type of IP pool, such as “Static IP” or “Dynamic IP.” | getPoolType(): ?string | setPoolType(?string poolType): void |
| `isDefaultPool` | `?bool` | Optional | True if this is the default IP pool for the account. | getIsDefaultPool(): ?bool | setIsDefaultPool(?bool isDefaultPool): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

