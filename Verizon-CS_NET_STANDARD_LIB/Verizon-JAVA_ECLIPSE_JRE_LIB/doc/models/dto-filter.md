
# Dto Filter

## Structure

`DtoFilter`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `MExpand` | `String` | Optional | Use to provide device details for alerts specific to a device | String getMExpand() | setMExpand(String mExpand) |
| `MLimitnumber` | `Integer` | Optional | Limit the number of results returned<br><br>**Constraints**: `>= 0`, `<= 100` | Integer getMLimitnumber() | setMLimitnumber(Integer mLimitnumber) |
| `MNopagination` | `Boolean` | Optional | A flag set to show if pagination requested (false) or not (true) | Boolean getMNopagination() | setMNopagination(Boolean mNopagination) |
| `MPage` | `String` | Optional | - | String getMPage() | setMPage(String mPage) |
| `MPagenumber` | `Integer` | Optional | **Constraints**: `>= 0`, `<= 100` | Integer getMPagenumber() | setMPagenumber(Integer mPagenumber) |
| `MProjection` | `List<String>` | Optional | Limits the fields of the device that the user is interested in rather than all of the fields<br><br>**Constraints**: *Maximum Items*: `100` | List<String> getMProjection() | setMProjection(List<String> mProjection) |
| `MSelection` | `Map<String, Object>` | Optional | Filters results based on user defined criteria | Map<String, Object> getMSelection() | setMSelection(Map<String, Object> mSelection) |

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

