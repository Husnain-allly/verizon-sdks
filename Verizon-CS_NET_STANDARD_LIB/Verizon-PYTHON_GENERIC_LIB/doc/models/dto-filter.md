
# Dto Filter

## Structure

`DtoFilter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `m_expand` | `str` | Optional | Use to provide device details for alerts specific to a device |
| `m_limitnumber` | `int` | Optional | Limit the number of results returned<br><br>**Constraints**: `>= 0`, `<= 100` |
| `m_nopagination` | `bool` | Optional | A flag set to show if pagination requested (false) or not (true) |
| `m_page` | `str` | Optional | - |
| `m_pagenumber` | `int` | Optional | **Constraints**: `>= 0`, `<= 100` |
| `m_projection` | `List[str]` | Optional | Limits the fields of the device that the user is interested in rather than all of the fields<br><br>**Constraints**: *Maximum Items*: `100` |
| `m_selection` | `Dict[str, Any]` | Optional | Filters results based on user defined criteria |

## Example (as JSON)

```json
{
  "$expand": "device detail(s)",
  "$nopagination": true,
  "$page": "The number of pages",
  "$limitnumber": 76,
  "$pagenumber": 12
}
```

