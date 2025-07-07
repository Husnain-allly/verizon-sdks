
# Active Trigger Indicator

Whether the trigger is active or not.

*This model accepts additional fields of type array.*

## Structure

`ActiveTriggerIndicator`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `active` | `?bool` | Optional | Indicates if the trigger is active<br />True - trigger is active<br />False - trigger is not active. | getActive(): ?bool | setActive(?bool active): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "active": true,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

