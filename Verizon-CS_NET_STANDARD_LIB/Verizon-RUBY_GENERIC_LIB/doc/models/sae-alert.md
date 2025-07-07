
# Sae Alert

## Structure

`SaeAlert`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `type_event` | `Integer` | Required | The ITIS Code that describes the alert/danger/hazard. All ITS standards use the same types here to explain the type of the alert/danger/hazard involved.<br><br>The complete set of ITIS codes can be found in Volume Two of the SAE J2540 standard. This is a set of over 1000 items which are used to encode common events and list items in ITS.<br><br>**Constraints**: `>= 0`, `<= 65535` |
| `description` | `Array<Integer>` | Optional | ITIS code set entries to further describe the event, give advice, or any other ITIS codes related to the event/danger/hazard.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `8`, `>= 0`, `<= 65535` |

## Example (as JSON)

```json
{
  "typeEvent": 68,
  "description": [
    229,
    228
  ]
}
```

