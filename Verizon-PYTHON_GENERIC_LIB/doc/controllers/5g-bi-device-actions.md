# 5G BI Device Actions

```python
m_5g_bi_device_actions_api = client.m_5g_bi_device_actions
```

## Class Name

`M5GBiDeviceActionsApi`

## Methods

* [Business Internetlist Device Information](../../doc/controllers/5g-bi-device-actions.md#business-internetlist-device-information)
* [Business Internetactivate Using POST](../../doc/controllers/5g-bi-device-actions.md#business-internetactivate-using-post)
* [Business Internet Serviceplanchange](../../doc/controllers/5g-bi-device-actions.md#business-internet-serviceplanchange)


# Business Internetlist Device Information

Uses the decive's Integrated Circuit Card Identification Number (ICCID) to retrive and display the device's properties.

```python
def business_internetlist_device_information(self,
                                            body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`M5GBideviceId`](../../doc/models/m-5g-bidevice-id.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`M5GBideviceDetailsresponse`](../../doc/models/m-5g-bidevice-detailsresponse.md).

## Example Usage

```python
body = M5GBideviceId(
    additional_properties=None,
    device_id=M5GBideviceId1(
        additional_properties=None,
        id='20-digit ICCID',
        kind='iccid'
    )
)

result = m_5g_bi_device_actions_api.business_internetlist_device_information(body)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`M5GBiRestErrorResponseException`](../../doc/models/m-5g-bi-rest-error-response-exception.md) |


# Business Internetactivate Using POST

Uses the device's ICCID and IMEI to activate service.

```python
def business_internetactivate_using_post(self,
                                        body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`M5GBiactivateRequest`](../../doc/models/m-5g-biactivate-request.md) | Body, Required | Activate 5G BI service. Defining <code>publicIpRestriction</code> as "Unrestricted" or "Restricted" is required for activating as Public Static. Leave  <code>publicIpRestriction</code> undefined to activate as Public Dynamic. Removing <code>publicIpRestriction</code> from the request will activate as Mobile Private Network (MPN). |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`M5GBiRequestResponse`](../../doc/models/m-5g-bi-request-response.md).

## Example Usage

```python
body = M5GBiactivateRequest(
    additional_properties=None,
    account_name='0000123456-00001',
    service_plan='service plan name',
    device_list_with_service_address=[
        DeviceListWithServiceAddress1(
            additional_properties=None,
            device_id=[
                M5GBideviceId1(
                    additional_properties=None,
                    id='15-digit IMEI',
                    kind='imei'
                ),
                M5GBideviceId1(
                    additional_properties=None,
                    id='20-digit ICCID',
                    kind='iccid'
                )
            ]
        ),
        DeviceListWithServiceAddress1(
            additional_properties=None,
            primary_placeofuse=M5GBiprimaryPlaceofuse(
                additional_properties=None,
                address=M5GBiAddress(
                    additional_properties=None,
                    address_line_1='street number and name',
                    city='city of address',
                    state='2-letter state ID (conforms to ISO 3166-2)',
                    zip='5-digit ZIP code',
                    zip_4='the +4 digits used for ZIP codes',
                    phone='a 10-digit phone number',
                    phone_type='W'
                ),
                customer_name=M5GBiCustomerName(
                    additional_properties=None,
                    first_name='First name',
                    last_name='Surname or Last Name',
                    middle_name='middle name or initial',
                    title='Mr. or Ms.',
                    suffex='Dr or Esq'
                )
            )
        )
    ],
    public_ip_restriction='Unrestricted',
    carrier_name='Verizon Wireless',
    mdn_zip_code='the 5-digit ZIP code of the Mobile Directory Number (MDN)'
)

result = m_5g_bi_device_actions_api.business_internetactivate_using_post(body)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
```

## Example Response *(as JSON)*

```json
{
  "requestId": "d1f08526-5443-4054-9a29-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`M5GBiRestErrorResponseException`](../../doc/models/m-5g-bi-rest-error-response-exception.md) |


# Business Internet Serviceplanchange

Change a device's service plan to use 5G BI.

```python
def business_internet_serviceplanchange(self,
                                       body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`M5GBichangeRequest`](../../doc/models/m-5g-bichange-request.md) | Body, Required | This endpoint is for use when changing a device's service plan to a 5G BI service plan. The service plan can change for an active device up to four times per month but will require address validation for each change. The service plan cannot be changed for a device while its service is suspended. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`M5GBiRequestResponse`](../../doc/models/m-5g-bi-request-response.md).

## Example Usage

```python
body = M5GBichangeRequest(
    additional_properties=None,
    account_name='0000123456-00001',
    service_plan='5G BI service plan name being changed to',
    device_list_with_service_address=[
        DeviceListWithServiceAddress(
            additional_properties=None,
            device_id=[
                M5GBideviceId1(
                    additional_properties=None,
                    id='15-digit IMEI',
                    kind='imei'
                )
            ]
        ),
        DeviceListWithServiceAddress(
            additional_properties=None,
            primary_placeofuse=M5GBiaddressAndcustomerinfo(
                additional_properties={
                    'address': jsonpickle.decode('{"addressLine1":"street number and name","city":"city of address","state":"2-letter state ID (conforms to ISO 3166-2)","zip":"5-digit ZIP code","zip+4":"the +4 digits used for ZIP codes"}'),
                    'customerName': jsonpickle.decode('{"firstName":"First name","lastName":"Surname or Last Name"}')
                }
            )
        )
    ],
    current_service_plan='Name of the plan being changed from'
)

result = m_5g_bi_device_actions_api.business_internet_serviceplanchange(body)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
```

## Example Response *(as JSON)*

```json
{
  "requestId": "d1f08526-5443-4054-9a29-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`M5GBiRestErrorResponseException`](../../doc/models/m-5g-bi-rest-error-response-exception.md) |

