/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package com.verizon.m5gedge.models;

import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.annotation.JsonSetter;

/**
 * This is a model class for DtoSensorOffBoardStatusRequest type.
 */
public class DtoSensorOffBoardStatusRequest {
    private String accountname;
    private Gatewayidentifier gatewayidentifier;
    private Offboarding offboarding;

    /**
     * Default constructor.
     */
    public DtoSensorOffBoardStatusRequest() {
    }

    /**
     * Initialization constructor.
     * @param  accountname  String value for accountname.
     * @param  gatewayidentifier  Gatewayidentifier value for gatewayidentifier.
     * @param  offboarding  Offboarding value for offboarding.
     */
    public DtoSensorOffBoardStatusRequest(
            String accountname,
            Gatewayidentifier gatewayidentifier,
            Offboarding offboarding) {
        this.accountname = accountname;
        this.gatewayidentifier = gatewayidentifier;
        this.offboarding = offboarding;
    }

    /**
     * Getter for Accountname.
     * The numeric account name, which must include leading zeros
     * @return Returns the String
     */
    @JsonGetter("accountname")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getAccountname() {
        return accountname;
    }

    /**
     * Setter for Accountname.
     * The numeric account name, which must include leading zeros
     * @param accountname Value for String
     */
    @JsonSetter("accountname")
    public void setAccountname(String accountname) {
        this.accountname = accountname;
    }

    /**
     * Getter for Gatewayidentifier.
     * @return Returns the Gatewayidentifier
     */
    @JsonGetter("gatewayidentifier")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public Gatewayidentifier getGatewayidentifier() {
        return gatewayidentifier;
    }

    /**
     * Setter for Gatewayidentifier.
     * @param gatewayidentifier Value for Gatewayidentifier
     */
    @JsonSetter("gatewayidentifier")
    public void setGatewayidentifier(Gatewayidentifier gatewayidentifier) {
        this.gatewayidentifier = gatewayidentifier;
    }

    /**
     * Getter for Offboarding.
     * @return Returns the Offboarding
     */
    @JsonGetter("offboarding")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public Offboarding getOffboarding() {
        return offboarding;
    }

    /**
     * Setter for Offboarding.
     * @param offboarding Value for Offboarding
     */
    @JsonSetter("offboarding")
    public void setOffboarding(Offboarding offboarding) {
        this.offboarding = offboarding;
    }

    /**
     * Converts this DtoSensorOffBoardStatusRequest into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "DtoSensorOffBoardStatusRequest [" + "accountname=" + accountname
                + ", gatewayidentifier=" + gatewayidentifier + ", offboarding=" + offboarding + "]";
    }

    /**
     * Builds a new {@link DtoSensorOffBoardStatusRequest.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link DtoSensorOffBoardStatusRequest.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .accountname(getAccountname())
                .gatewayidentifier(getGatewayidentifier())
                .offboarding(getOffboarding());
        return builder;
    }

    /**
     * Class to build instances of {@link DtoSensorOffBoardStatusRequest}.
     */
    public static class Builder {
        private String accountname;
        private Gatewayidentifier gatewayidentifier;
        private Offboarding offboarding;



        /**
         * Setter for accountname.
         * @param  accountname  String value for accountname.
         * @return Builder
         */
        public Builder accountname(String accountname) {
            this.accountname = accountname;
            return this;
        }

        /**
         * Setter for gatewayidentifier.
         * @param  gatewayidentifier  Gatewayidentifier value for gatewayidentifier.
         * @return Builder
         */
        public Builder gatewayidentifier(Gatewayidentifier gatewayidentifier) {
            this.gatewayidentifier = gatewayidentifier;
            return this;
        }

        /**
         * Setter for offboarding.
         * @param  offboarding  Offboarding value for offboarding.
         * @return Builder
         */
        public Builder offboarding(Offboarding offboarding) {
            this.offboarding = offboarding;
            return this;
        }

        /**
         * Builds a new {@link DtoSensorOffBoardStatusRequest} object using the set fields.
         * @return {@link DtoSensorOffBoardStatusRequest}
         */
        public DtoSensorOffBoardStatusRequest build() {
            return new DtoSensorOffBoardStatusRequest(accountname, gatewayidentifier, offboarding);
        }
    }
}
