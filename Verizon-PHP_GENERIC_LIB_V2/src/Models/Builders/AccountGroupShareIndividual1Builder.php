<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\AccountGroupShareFilterCriteria;
use VerizonLib\Models\AccountGroupShareIndividual1;

/**
 * Builder for model AccountGroupShareIndividual1
 *
 * @see AccountGroupShareIndividual1
 */
class AccountGroupShareIndividual1Builder
{
    /**
     * @var AccountGroupShareIndividual1
     */
    private $instance;

    private function __construct(AccountGroupShareIndividual1 $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Account Group Share Individual 1 Builder object.
     */
    public static function init(): self
    {
        return new self(new AccountGroupShareIndividual1());
    }

    /**
     * Sets account Group Share Individual field.
     *
     * @param AccountGroupShareFilterCriteria|null $value
     */
    public function accountGroupShareIndividual(?AccountGroupShareFilterCriteria $value): self
    {
        $this->instance->setAccountGroupShareIndividual($value);
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
     * Initializes a new Account Group Share Individual 1 object.
     */
    public function build(): AccountGroupShareIndividual1
    {
        return CoreHelper::clone($this->instance);
    }
}
