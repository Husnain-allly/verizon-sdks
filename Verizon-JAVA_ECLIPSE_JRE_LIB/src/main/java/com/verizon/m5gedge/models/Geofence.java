/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package com.verizon.m5gedge.models;

import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonSetter;
import java.util.List;

/**
 * This is a model class for Geofence type.
 */
public class Geofence {
    private String type;
    private List<List<Double>> coordinates;

    /**
     * Default constructor.
     */
    public Geofence() {
    }

    /**
     * Initialization constructor.
     * @param  type  String value for type.
     * @param  coordinates  List of Double value for coordinates.
     */
    public Geofence(
            String type,
            List<List<Double>> coordinates) {
        this.type = type;
        this.coordinates = coordinates;
    }

    /**
     * Getter for Type.
     * @return Returns the String
     */
    @JsonGetter("type")
    public String getType() {
        return type;
    }

    /**
     * Setter for Type.
     * @param type Value for String
     */
    @JsonSetter("type")
    public void setType(String type) {
        this.type = type;
    }

    /**
     * Getter for Coordinates.
     * @return Returns the List of Double
     */
    @JsonGetter("coordinates")
    public List<List<Double>> getCoordinates() {
        return coordinates;
    }

    /**
     * Setter for Coordinates.
     * @param coordinates Value for List of Double
     */
    @JsonSetter("coordinates")
    public void setCoordinates(List<List<Double>> coordinates) {
        this.coordinates = coordinates;
    }

    /**
     * Converts this Geofence into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "Geofence [" + "type=" + type + ", coordinates=" + coordinates + "]";
    }

    /**
     * Builds a new {@link Geofence.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link Geofence.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder(type, coordinates);
        return builder;
    }

    /**
     * Class to build instances of {@link Geofence}.
     */
    public static class Builder {
        private String type;
        private List<List<Double>> coordinates;

        /**
         * Initialization constructor.
         */
        public Builder() {
        }

        /**
         * Initialization constructor.
         * @param  type  String value for type.
         * @param  coordinates  List of Double value for coordinates.
         */
        public Builder(String type, List<List<Double>> coordinates) {
            this.type = type;
            this.coordinates = coordinates;
        }

        /**
         * Setter for type.
         * @param  type  String value for type.
         * @return Builder
         */
        public Builder type(String type) {
            this.type = type;
            return this;
        }

        /**
         * Setter for coordinates.
         * @param  coordinates  List of Double value for coordinates.
         * @return Builder
         */
        public Builder coordinates(List<List<Double>> coordinates) {
            this.coordinates = coordinates;
            return this;
        }

        /**
         * Builds a new {@link Geofence} object using the set fields.
         * @return {@link Geofence}
         */
        public Geofence build() {
            return new Geofence(type, coordinates);
        }
    }
}
