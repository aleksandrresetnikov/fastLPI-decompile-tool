package com.sane5k.peoples;

import processing.core.*;
import processing.data.*;
import processing.event.*;
import processing.opengl.*;

import java.util.HashMap;
import java.util.ArrayList;
import java.io.File;
import java.io.BufferedReader;
import java.io.PrintWriter;
import java.io.InputStream;
import java.io.OutputStream;
import java.io.IOException;

public class MainApplet extends PApplet {
    ArrayList<Ball> balls = new ArrayList<Ball>();

    public void setup() {
        balls.add(new Ball(100, 400, 20));

        for (int i = 0; i < 185; i++)
            balls.add(new Ball(random(5, 10)));

    }

    long fps = 0;
    long render_interval_timer = millis() + 1000;
    long render_interval = 0;
    public void draw() {
        render_interval = millis();

        background(51);

        for (Ball b : balls) {
            b.update();
            b.display();
            b.checkBoundaryCollision();
        }

        for (int i = 0; i < balls.size(); i++)
            for (int j = 0; j < balls.size(); j++)
                if (i != j)
                    balls.get(i).checkCollision(balls.get(j));

        int fpsTextSize = 16;
        textSize(fpsTextSize);
        fill(0xffFFFFFF);
        text("AVG: " + fps, 10, fpsTextSize + 10);

        if (render_interval_timer < millis()){
            fps = 1000/(millis() - render_interval);
            render_interval_timer = millis() + 100;
        }
    }

    class Ball {
        PVector position;
        PVector velocity;

        float radius, m;

        Ball(float x, float y, float r_) {
            position = new PVector(x, y);
            velocity = PVector.random2D();
            velocity.mult(3);
            radius = r_;
            m = radius*.1f;
        }

        Ball(float r_) {
            position = new PVector(random(0, width - r_), random(0, height - r_));
            velocity = PVector.random2D();
            velocity.mult(3);
            radius = r_;
            m = radius*.1f;
        }

        public void update() {
            position.add(velocity);
        }

        public void checkBoundaryCollision() {
            if (position.x > width-radius) {
                position.x = width-radius;
                velocity.x *= -1;
            } else if (position.x < radius) {
                position.x = radius;
                velocity.x *= -1;
            } else if (position.y > height-radius) {
                position.y = height-radius;
                velocity.y *= -1;
            } else if (position.y < radius) {
                position.y = radius;
                velocity.y *= -1;
            }
        }

        public void checkCollision(Ball other) {

            PVector distanceVect = PVector.sub(other.position, position);

            float distanceVectMag = distanceVect.mag();

            float minDistance = radius + other.radius;

            if (distanceVectMag < minDistance) {
                float distanceCorrection = (minDistance-distanceVectMag)/2.0f;
                PVector d = distanceVect.copy();
                PVector correctionVector = d.normalize().mult(distanceCorrection);
                other.position.add(correctionVector);
                position.sub(correctionVector);

                float theta  = distanceVect.heading();
                float sine = sin(theta);
                float cosine = cos(theta);

                PVector[] bTemp = {
                        new PVector(), new PVector()
                };

                bTemp[1].x  = cosine * distanceVect.x + sine * distanceVect.y;
                bTemp[1].y  = cosine * distanceVect.y - sine * distanceVect.x;

                PVector[] vTemp = {
                        new PVector(), new PVector()
                };

                vTemp[0].x  = cosine * velocity.x + sine * velocity.y;
                vTemp[0].y  = cosine * velocity.y - sine * velocity.x;
                vTemp[1].x  = cosine * other.velocity.x + sine * other.velocity.y;
                vTemp[1].y  = cosine * other.velocity.y - sine * other.velocity.x;

                PVector[] vFinal = {
                        new PVector(), new PVector()
                };

                vFinal[0].x = ((m - other.m) * vTemp[0].x + 2 * other.m * vTemp[1].x) / (m + other.m);
                vFinal[0].y = vTemp[0].y;

                vFinal[1].x = ((other.m - m) * vTemp[1].x + 2 * m * vTemp[0].x) / (m + other.m);
                vFinal[1].y = vTemp[1].y;

                bTemp[0].x += vFinal[0].x;
                bTemp[1].x += vFinal[1].x;

                PVector[] bFinal = {
                        new PVector(), new PVector()
                };

                bFinal[0].x = cosine * bTemp[0].x - sine * bTemp[0].y;
                bFinal[0].y = cosine * bTemp[0].y + sine * bTemp[0].x;
                bFinal[1].x = cosine * bTemp[1].x - sine * bTemp[1].y;
                bFinal[1].y = cosine * bTemp[1].y + sine * bTemp[1].x;

                other.position.x = position.x + bFinal[1].x;
                other.position.y = position.y + bFinal[1].y;

                position.add(bFinal[0]);

                velocity.x = cosine * vFinal[0].x - sine * vFinal[0].y;
                velocity.y = cosine * vFinal[0].y + sine * vFinal[0].x;
                other.velocity.x = cosine * vFinal[1].x - sine * vFinal[1].y;
                other.velocity.y = cosine * vFinal[1].y + sine * vFinal[1].x;
            }
        }

        public void display() {
            noStroke();
            fill(204);
            ellipse(position.x, position.y, radius*2, radius*2);
        }
    }

    public void settings() {  fullScreen(); }

    static public void main(String[] passedArgs) {
        String[] appletArgs = new String[] { "MainApplet" };
        if (passedArgs != null) {
            PApplet.main(concat(appletArgs, passedArgs));
        } else {
            PApplet.main(appletArgs);
        }
    }
}