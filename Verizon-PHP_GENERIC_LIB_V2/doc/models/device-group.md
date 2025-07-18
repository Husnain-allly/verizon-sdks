
# Device Group

Returns a list of all device groups in a specified account.

*This model accepts additional fields of type array.*

## Structure

`DeviceGroup`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `description` | `?string` | Optional | The description of the device group. | getDescription(): ?string | setDescription(?string description): void |
| `extendedAttributes` | [`?(CustomFields[])`](../../doc/models/custom-fields.md) | Optional | Any extended attributes for the device group, as Key and Value pairs. | getExtendedAttributes(): ?array | setExtendedAttributes(?array extendedAttributes): void |
| `isDefaultGroup` | `?bool` | Optional | Identifies the default device group. | getIsDefaultGroup(): ?bool | setIsDefaultGroup(?bool isDefaultGroup): void |
| `name` | `?string` | Optional | The name of the device group. | getName(): ?string | setName(?string name): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "name": "Unassigned Devices",
  "description": "All devices that are not in another device group.",
  "isDefaultGroup": true,
  "extendedAttributes": [],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

