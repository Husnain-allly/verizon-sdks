
# Item 1

## Structure

`Item1`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Text` | `String` | Required | Simple text used with ITIS codes. (Text taken from SAE J2540.)<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `500`, *Pattern*: ``^[\w\+\-!()\`\[\]{=};\"':,.\/<>?\|\s]+$`` | String getText() | setText(String text) |

## Example (as JSON)

```json
{
  "text": "text4"
}
```

