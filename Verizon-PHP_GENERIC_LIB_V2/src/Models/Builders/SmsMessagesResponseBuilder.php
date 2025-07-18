<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models\Builders;

use Core\Utils\CoreHelper;
use VerizonLib\Models\GioSmsMessage;
use VerizonLib\Models\SmsMessagesResponse;

/**
 * Builder for model SmsMessagesResponse
 *
 * @see SmsMessagesResponse
 */
class SmsMessagesResponseBuilder
{
    /**
     * @var SmsMessagesResponse
     */
    private $instance;

    private function __construct(SmsMessagesResponse $instance)
    {
        $this->instance = $instance;
    }

    /**
     * Initializes a new Sms Messages Response Builder object.
     */
    public static function init(): self
    {
        return new self(new SmsMessagesResponse());
    }

    /**
     * Sets messages field.
     *
     * @param GioSmsMessage[]|null $value
     */
    public function messages(?array $value): self
    {
        $this->instance->setMessages($value);
        return $this;
    }

    /**
     * Sets has More Data field.
     *
     * @param bool|null $value
     */
    public function hasMoreData(?bool $value): self
    {
        $this->instance->setHasMoreData($value);
        return $this;
    }

    /**
     * Initializes a new Sms Messages Response object.
     */
    public function build(): SmsMessagesResponse
    {
        return CoreHelper::clone($this->instance);
    }
}
