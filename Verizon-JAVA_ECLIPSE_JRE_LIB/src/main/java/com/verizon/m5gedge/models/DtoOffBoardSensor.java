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
 * This is a model class for DtoOffBoardSensor type.
 */
public class DtoOffBoardSensor {
    private String deveui;

    /**
     * Default constructor.
     */
    public DtoOffBoardSensor() {
    }

    /**
     * Initialization constructor.
     * @param  deveui  String value for deveui.
     */
    public DtoOffBoardSensor(
            String deveui) {
        this.deveui = deveui;
    }

    /**
     * Getter for Deveui.
     * the IEEE EUI64 address space used to identify a device. It is supplied by the device
     * manufacturer
     * @return Returns the String
     */
    @JsonGetter("deveui")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getDeveui() {
        return deveui;
    }

    /**
     * Setter for Deveui.
     * the IEEE EUI64 address space used to identify a device. It is supplied by the device
     * manufacturer
     * @param deveui Value for String
     */
    @JsonSetter("deveui")
    public void setDeveui(String deveui) {
        this.deveui = deveui;
    }

    /**
     * Converts this DtoOffBoardSensor into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "DtoOffBoardSensor [" + "deveui=" + deveui + "]";
    }

    /**
     * Builds a new {@link DtoOffBoardSensor.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link DtoOffBoardSensor.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .deveui(getDeveui());
        return builder;
    }

    /**
     * Class to build instances of {@link DtoOffBoardSensor}.
     */
    public static class Builder {
        private String deveui;



        /**
         * Setter for deveui.
         * @param  deveui  String value for deveui.
         * @return Builder
         */
        public Builder deveui(String deveui) {
            this.deveui = deveui;
            return this;
        }

        /**
         * Builds a new {@link DtoOffBoardSensor} object using the set fields.
         * @return {@link DtoOffBoardSensor}
         */
        public DtoOffBoardSensor build() {
            return new DtoOffBoardSensor(deveui);
        }
    }
}
