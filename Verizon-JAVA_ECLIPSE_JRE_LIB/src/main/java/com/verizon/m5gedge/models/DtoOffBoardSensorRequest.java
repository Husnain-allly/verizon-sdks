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
 * This is a model class for DtoOffBoardSensorRequest type.
 */
public class DtoOffBoardSensorRequest {
    private String accountname;
    private Sensorinsightsconfig configuration;

    /**
     * Default constructor.
     */
    public DtoOffBoardSensorRequest() {
    }

    /**
     * Initialization constructor.
     * @param  accountname  String value for accountname.
     * @param  configuration  Sensorinsightsconfig value for configuration.
     */
    public DtoOffBoardSensorRequest(
            String accountname,
            Sensorinsightsconfig configuration) {
        this.accountname = accountname;
        this.configuration = configuration;
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
     * Getter for Configuration.
     * The configuration of the remove request
     * @return Returns the Sensorinsightsconfig
     */
    @JsonGetter("configuration")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public Sensorinsightsconfig getConfiguration() {
        return configuration;
    }

    /**
     * Setter for Configuration.
     * The configuration of the remove request
     * @param configuration Value for Sensorinsightsconfig
     */
    @JsonSetter("configuration")
    public void setConfiguration(Sensorinsightsconfig configuration) {
        this.configuration = configuration;
    }

    /**
     * Converts this DtoOffBoardSensorRequest into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "DtoOffBoardSensorRequest [" + "accountname=" + accountname + ", configuration="
                + configuration + "]";
    }

    /**
     * Builds a new {@link DtoOffBoardSensorRequest.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link DtoOffBoardSensorRequest.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .accountname(getAccountname())
                .configuration(getConfiguration());
        return builder;
    }

    /**
     * Class to build instances of {@link DtoOffBoardSensorRequest}.
     */
    public static class Builder {
        private String accountname;
        private Sensorinsightsconfig configuration;



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
         * Setter for configuration.
         * @param  configuration  Sensorinsightsconfig value for configuration.
         * @return Builder
         */
        public Builder configuration(Sensorinsightsconfig configuration) {
            this.configuration = configuration;
            return this;
        }

        /**
         * Builds a new {@link DtoOffBoardSensorRequest} object using the set fields.
         * @return {@link DtoOffBoardSensorRequest}
         */
        public DtoOffBoardSensorRequest build() {
            return new DtoOffBoardSensorRequest(accountname, configuration);
        }
    }
}
