<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Authentication;

/**
 * Interface for defining the behavior of Authentication.
 */
interface VzM2MTokenCredentials
{
    /**
     * String value for vzM2MToken.
     */
    public function getVzM2MToken(): string;

    /**
     * Checks if provided credentials match with existing ones.
     *
     * @param string $vzM2MToken M2M Session Token ([How to generate an M2M session
     *        token?]($e/Session%20Management/StartConnectivityManagementSession))
     */
    public function equals(string $vzM2MToken): bool;
}
