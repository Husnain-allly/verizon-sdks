# Sensor Insights Rules

```php
$sensorInsightsRulesApi = $client->getSensorInsightsRulesApi();
```

## Class Name

`SensorInsightsRulesApi`

## Methods

* [Sensor Insights Overwrite Rule Request](../../doc/controllers/sensor-insights-rules.md#sensor-insights-overwrite-rule-request)
* [Sensor Insights List Rules Request](../../doc/controllers/sensor-insights-rules.md#sensor-insights-list-rules-request)


# Sensor Insights Overwrite Rule Request

```php
function sensorInsightsOverwriteRuleRequest(DtoOverwriteRuleRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoOverwriteRuleRequest`](../../doc/models/dto-overwrite-rule-request.md) | Body, Required | Overwrite a rule |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`ResourceRule`](../../doc/models/resource-rule.md).

## Example Usage

```php
$body = DtoOverwriteRuleRequestBuilder::init()
    ->accountname('0000123456-00001')
    ->resourceidentifier(
        DtoResourceidentifierBuilder::init()
            ->id('7f5f610a-eeee-ffff-gggg-4d20cf3dcfbc')
            ->build()
    )
    ->rule(
        ResourceRuleBuilder::init(
            DateTimeHelper::fromRfc3339DateTimeRequired('2023-10-02T15:46:34.562Z'),
            'c1f178d3-eeee-ffff-gggg-0d6b7ae6022a',
            DateTimeHelper::fromRfc3339DateTimeRequired('2023-10-02T15:46:34.562Z'),
            ApiHelper::deserialize('{}'),
            '337bd2e8-eeee-ffff-gggg-5207992fd395'
        )
            ->accountclientid('null')
            ->billingaccountid('The billing account ID')
            ->description('a short description')
            ->deviceid('The UUID of the device')
            ->disabled(true)
            ->id('bc5b5b5a-eeee-ffff-gggg-cb2cb2533d47')
            ->name('User defined name of the record')
            ->rulesyntax('The rule syntax')
            ->version('1.0')
            ->build()
    )
    ->build();

$apiResponse = $sensorInsightsRulesApi->sensorInsightsOverwriteRuleRequest($body);
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`M400ManagementErrorException`](../../doc/models/m400-management-error-exception.md) |
| 401 | UnAuthorized | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |
| 404 | Not Found | [`M404ManagementErrorException`](../../doc/models/m404-management-error-exception.md) |
| 406 | Not Acceptable | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 415 | Unsupported media type | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 429 | Too many requests | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |
| Default | Unexpected error | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |


# Sensor Insights List Rules Request

```php
function sensorInsightsListRulesRequest(DtoListRulesRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoListRulesRequest`](../../doc/models/dto-list-rules-request.md) | Body, Required | Retrieve a rule |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`ResourceRule[]`](../../doc/models/resource-rule.md).

## Example Usage

```php
$body = DtoListRulesRequestBuilder::init()
    ->accountname('0000123456-00001')
    ->filter(
        DtoFilterBuilder::init()
            ->mExpand('device detail(s)')
            ->mLimitnumber(100)
            ->mNopagination(true)
            ->mPage('The number of pages')
            ->mPagenumber(100)
            ->mProjection(
                [
                    'specific device fields requested'
                ]
            )
            ->mSelection(
                [
                    'additionalProp1' => ApiHelper::deserialize('"string"'),
                    'additionalProp2' => ApiHelper::deserialize('"string"'),
                    'additionalProp3' => ApiHelper::deserialize('"string"')
                ]
            )
            ->build()
    )
    ->resourceidentifier(
        DtoResourceidentifierBuilder::init()
            ->id('ffb86390-eeee-ffff-gggg-9d1180882d63')
            ->build()
    )
    ->build();

$apiResponse = $sensorInsightsRulesApi->sensorInsightsListRulesRequest($body);
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`M400ManagementErrorException`](../../doc/models/m400-management-error-exception.md) |
| 401 | UnAuthorized | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |
| 404 | Not Found | [`M404ManagementErrorException`](../../doc/models/m404-management-error-exception.md) |
| 406 | Not Acceptable | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 415 | Unsupported media type | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 429 | Too many requests | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |
| Default | Unexpected error | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |

