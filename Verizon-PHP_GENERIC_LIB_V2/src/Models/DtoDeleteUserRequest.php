<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models;

use stdClass;
use VerizonLib\ApiHelper;

class DtoDeleteUserRequest implements \JsonSerializable
{
    /**
     * @var string|null
     */
    private $accountname;

    /**
     * @var string|null
     */
    private $id;

    /**
     * Returns Accountname.
     * The numeric account name, which must include leading zeros
     */
    public function getAccountname(): ?string
    {
        return $this->accountname;
    }

    /**
     * Sets Accountname.
     * The numeric account name, which must include leading zeros
     *
     * @maps accountname
     */
    public function setAccountname(?string $accountname): void
    {
        $this->accountname = $accountname;
    }

    /**
     * Returns Id.
     * UUID of the user record, assigned at creation
     */
    public function getId(): ?string
    {
        return $this->id;
    }

    /**
     * Sets Id.
     * UUID of the user record, assigned at creation
     *
     * @maps id
     */
    public function setId(?string $id): void
    {
        $this->id = $id;
    }

    /**
     * Converts the DtoDeleteUserRequest object to a human-readable string representation.
     *
     * @return string The string representation of the DtoDeleteUserRequest object.
     */
    public function __toString(): string
    {
        return ApiHelper::stringify(
            'DtoDeleteUserRequest',
            ['accountname' => $this->accountname, 'id' => $this->id]
        );
    }

    /**
     * Encode this object to JSON
     *
     * @param bool $asArrayWhenEmpty Whether to serialize this model as an array whenever no fields
     *        are set. (default: false)
     *
     * @return array|stdClass
     */
    #[\ReturnTypeWillChange] // @phan-suppress-current-line PhanUndeclaredClassAttribute for (php < 8.1)
    public function jsonSerialize(bool $asArrayWhenEmpty = false)
    {
        $json = [];
        if (isset($this->accountname)) {
            $json['accountname'] = $this->accountname;
        }
        if (isset($this->id)) {
            $json['id']          = $this->id;
        }

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
