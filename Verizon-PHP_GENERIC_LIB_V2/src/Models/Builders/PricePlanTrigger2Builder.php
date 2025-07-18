<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\AccountShareFilterCriteria;
use VerizonLib\Models\Actionobject;
use VerizonLib\Models\ChangePlanDetails;
use VerizonLib\Models\FiltercriteriaObjectCall;
use VerizonLib\Models\PayAsYouGoFilterCriteria;
use VerizonLib\Models\PricePlanTrigger2;
use VerizonLib\Models\Rateplantype2Condition;

/**
 * Builder for model PricePlanTrigger2
 *
 * @see PricePlanTrigger2
 */
class PricePlanTrigger2Builder
{
    /**
     * @var PricePlanTrigger2
     */
    private $instance;

    private function __construct(PricePlanTrigger2 $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Price Plan Trigger 2 Builder object.
     */
    public static function init(): self
    {
        return new self(new PricePlanTrigger2());
    }

    /**
     * Sets account Share field.
     *
     * @param AccountShareFilterCriteria|null $value
     */
    public function accountShare(?AccountShareFilterCriteria $value): self
    {
        $this->instance->setAccountShare($value);
        return $this;
    }

    /**
     * Sets condition field.
     *
     * @param Rateplantype2Condition|null $value
     */
    public function condition(?Rateplantype2Condition $value): self
    {
        $this->instance->setCondition($value);
        return $this;
    }

    /**
     * Sets change Plan field.
     *
     * @param bool|null $value
     */
    public function changePlan(?bool $value): self
    {
        $this->instance->setChangePlan($value);
        return $this;
    }

    /**
     * Sets change Plan Details field.
     *
     * @param ChangePlanDetails|null $value
     */
    public function changePlanDetails(?ChangePlanDetails $value): self
    {
        $this->instance->setChangePlanDetails($value);
        return $this;
    }

    /**
     * Sets pay As You Go field.
     *
     * @param PayAsYouGoFilterCriteria|null $value
     */
    public function payAsYouGo(?PayAsYouGoFilterCriteria $value): self
    {
        $this->instance->setPayAsYouGo($value);
        return $this;
    }

    /**
     * Sets action field.
     *
     * @param Actionobject|null $value
     */
    public function action(?Actionobject $value): self
    {
        $this->instance->setAction($value);
        return $this;
    }

    /**
     * Sets stand Alone field.
     *
     * @param FiltercriteriaObjectCall|null $value
     */
    public function standAlone(?FiltercriteriaObjectCall $value): self
    {
        $this->instance->setStandAlone($value);
        return $this;
    }

    /**
     * Add an additional property to this model.
     *
     * @param string $name Name of property.
     * @param mixed $value Value of property.
     */
    public function additionalProperty(string $name, $value): self
    {
        $this->instance->addAdditionalProperty($name, $value);
        return $this;
    }

    /**
     * Initializes a new Price Plan Trigger 2 object.
     */
    public function build(): PricePlanTrigger2
    {
        return CoreHelper::clone($this->instance);
    }
}
