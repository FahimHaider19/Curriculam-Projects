#include <iostream>
#include <GL/freeglut.h>
#include <GL/gl.h>
#include <GL/glu.h>
#include <vector>
#include <utility>
using namespace std;
struct Color
{
    int r;
    int g;
    int b;
};
void circle(float x, float y, float radius, Color color);
void quad(float x1, float x2, float y1, float y2, Color color, float Tx = 0, float Ty = 0, float s = 1)
{
    glColor3ub(color.r, color.g, color.b);
    glBegin(GL_QUADS);
    glVertex2f(s * x1 + Tx, s * y1 + Ty);
    glVertex2f(s * x2 + Tx, s * y1 + Ty);
    glVertex2f(s * x2 + Tx, s * y2 + Ty);
    glVertex2f(s * x1 + Tx, s * y2 + Ty);
    glEnd();
}
void quad(vector<pair<float, float>> coord, Color color = {255, 255, 255}, float Tx = 0, float Ty = 0, float s = 1)
{
    glColor3ub(color.r, color.g, color.b);
    glBegin(GL_QUADS);
    for (int i = 0; i < coord.size(); i++)
        glVertex2d(Tx + s * coord[i].first, Ty + s * coord[i].second);
    glEnd();
}
void triangle(vector<pair<float, float>> coord, Color color = {255, 255, 255}, float Tx = 0, float Ty = 0, float s = 1)
{
    glColor3ub(color.r, color.g, color.b);
    glBegin(GL_TRIANGLES);
    for (int i = 0; i < coord.size(); i++)
        glVertex2d(Tx + s * coord[i].first, Ty + s * coord[i].second);
    glEnd();
}
void polygon(vector<pair<float, float>> coord, Color color = {255, 255, 255}, float Tx = 0, float Ty = 0, float s = 1)
{
    glColor3ub(color.r, color.g, color.b);
    glBegin(GL_POLYGON);
    for (int i = 0; i < coord.size(); i++)
        glVertex2d(Tx + s * coord[i].first, Ty + s * coord[i].second);
    glEnd();
}
void house1(float x,float y,int m=1)
{

//green polygon
glColor3ub(1.0,1.0,0.0);
glBegin(GL_POLYGON);
glVertex2f(x+m*0,y+0);
glVertex2f(x+m*40.06,y+-0.01);
glVertex2f(x+m*40.14,y+26.27);
glVertex2f(x+m*19.84,y+48.1);
glVertex2f(x+m*-0.04,y+26.06);
glEnd();
//wall(side)
glColor3ub(100,100,100);
glBegin(GL_QUADS);
glVertex2f(x+m*40.06,y+-0.01);//mirror,translation
glVertex2f(x+m*87.76,y+-0.01);
glVertex2f(x+m*87.55,y+26.14);
glVertex2f(x+m*40.14,y+26.27);
//roof
glColor3ub(150,200,100);
//glBegin(GL_QUADS);
glVertex2f(x+m*19.84,y+48.1);
glVertex2f(x+m*40.14,y+26.27);
glVertex2f(x+m*87.55,y+26.14);
glVertex2f(x+m*67.91,y+47.99);
//windows
glColor3ub(250,200,60);
//glBegin(GL_QUADS);
glVertex2f(x+m*6.64,y+7.08);
glVertex2f(x+m*10.82,y+7.08);
glVertex2f(x+m*10.82,y+19.13);
glVertex2f(x+m*6.64,y+19.13);
glVertex2f(x+m*17.84,y+7.07);
glVertex2f(x+m*22.02,y+7.07);
glVertex2f(x+m*22.02,y+19.12);
glVertex2f(x+m*17.84,y+19.12);
glVertex2f(x+m*29.32,y+7.11);
glVertex2f(x+m*33.5,y+7.11);
glVertex2f(x+m*33.5,y+19.16);
glVertex2f(x+m*29.32,y+19.16);
glVertex2f(x+m*46.77,y+6.89);
glVertex2f(x+m*50.95,y+6.89);
glVertex2f(x+m*50.95,y+18.94);
glVertex2f(x+m*46.77,y+18.94);
glVertex2f(x+m*61.92,y+6.71);
glVertex2f(x+m*66.11,y+6.71);
glVertex2f(x+m*66.11,y+18.76);
glVertex2f(x+m*61.92,y+18.76);
glVertex2f(x+m*76.91,y+6.89);
glVertex2f(x+m*81.09,y+6.89);
glVertex2f(x+m*81.09,y+18.94);
glVertex2f(x+m*76.91,y+18.94);
glEnd();
}
void house2(float x,float y,int m=1)
{
    glColor3ub(250,200,60);
    glBegin(GL_POLYGON);
    glVertex2f(x+m*0,y+ 0);
    glVertex2f(x+m*40.07,y+ 0);
    glVertex2f(x+m*40.14,y+ 26.27);
    glVertex2f(x+m*19.84,y+ 48.1);
    glVertex2f(x+m*-0.04,y+ 26.06);
    glEnd();
    //
    glColor3ub(29,70,30);
    glBegin(GL_QUADS);
    glVertex2f(x+m*40.07,y+ 0);
    glVertex2f(x+m*141.26,y+ 0);
    glVertex2f(x+m*141.06,y+26.27);
    glVertex2f(x+m*40.14,y+ 26.27);
    glEnd();

    //door
    glColor3ub(25,20,70);
    glBegin(GL_QUADS);
    glVertex2f(x+m*19.84,y+ 48.1);
    glVertex2f(x+m*40.14,y+ 26.27);
    glVertex2f(x+m*141.06,y+ 26.27);
    glVertex2f(x+m*121.52,y+ 48.26);
    glEnd();
    //window
    glColor3ub(255,100,60);
    glBegin(GL_QUADS);
    glVertex2f(x+m*6.65,y+ 7.08);
    glVertex2f(x+m*10.83,y+ 7.08);
    glVertex2f(x+m*10.83,y+ 19.13);
    glVertex2f(x+m*6.65,y+ 19.13);
    glVertex2f(x+m*17.82,y+ 7.15);
    glVertex2f(x+m*22,y+ 7.15);
    glVertex2f(x+m*22,y+ 19.2);
    glVertex2f(x+m*17.82,y+ 19.2);
    glVertex2f(x+m*29.36,y+ 6.98);
    glVertex2f(x+m*33.54,y+ 6.98);
    glVertex2f(x+m*33.54,y+ 19.03);
    glVertex2f(x+m*29.36,y+ 19.03);
    glVertex2f(x+m*46.23,y+ 14.96);
    glVertex2f(x+m*50.83,y+ 14.96);
    glVertex2f(x+m*50.83,y+ 19.01);
    glVertex2f(x+m*46.23,y+ 19.01);
    glVertex2f(x+m*60.35,y+ 15.09);
    glVertex2f(x+m*64.94,y+ 15.09);
    glVertex2f(x+m*64.94,y+ 19.13);
    glVertex2f(x+m*60.35,y+ 19.13);
    glVertex2f(x+m*74.39,y+ 14.88);
    glVertex2f(x+m*78.99,y+ 14.88);
    glVertex2f(x+m*78.99,y+ 18.92);
    glVertex2f(x+m*74.39,y+ 18.92);
    glVertex2f(x+m*88.43,y+ 14.88);
    glVertex2f(x+m*93.03,y+ 14.88);
    glVertex2f(x+m*93.03,y+ 18.92);
    glVertex2f(x+m*88.43,y+ 18.92);
    glVertex2f(x+m*102.53,y+ 15.09);
    glVertex2f(x+m*107.12,y+ 15.09);
    glVertex2f(x+m*107.12,y+ 19.13);
    glVertex2f(x+m*102.53,y+ 19.13);
    glVertex2f(x+m*116.46,y+ 14.91);
    glVertex2f(x+m*121.06,y+ 14.91);
    glVertex2f(x+m*121.06,y+ 18.96);
    glVertex2f(x+m*116.46,y+ 18.96);
    glVertex2f(x+m*130.73,y+ 14.91);
    glVertex2f(x+m*135.33,y+ 14.91);
    glVertex2f(x+m*135.33,y+ 18.95);
    glVertex2f(x+m*130.73,y+ 18.95);
    glEnd();
}
void house3(float x,float y,int m=1)

{
    //polygon
    glColor3ub(55, 140, 30);
    glBegin(GL_POLYGON);
    glVertex2f(x + m * 0, y + 0);
    glVertex2f(x + m * 40.34, y + 0);
    glVertex2f(x + m * 40.34, y + 51.78);
    glVertex2f(x + m * 19.91, y + 74.55);
    glVertex2f(x + m * 0.26, y + 52.67);
    glEnd();
    //windows
    glColor3ub(124, 170, 120);
    glBegin(GL_QUADS);
    glVertex2f(x + m * 40.34, y + 0);
    glVertex2f(x + m * 101.25, y + 0);
    glVertex2f(x + m * 101.22, y + 52.29);
    glVertex2f(x + m * 40.34, y + 51.78);

    glColor3ub(25, 0, 230);
    glVertex2f(x + m * 19.91, y + 74.55);
    glVertex2f(x + m * 40.34, y + 51.78);
    glVertex2f(x + m * 101.22, y + 52.29);
    glVertex2f(x + m * 81.25, y + 74.62);

    glColor3ub(155, 240, 90);
    glVertex2f(x + m * 5.71, y + 33.74);
    glVertex2f(x + m * 15.4, y + 33.74);
    glVertex2f(x + m * 15.4, y + 45.7);
    glVertex2f(x + m * 5.71, y + 45.7);
    glVertex2f(x + m * 24.99, y + 33.5);
    glVertex2f(x + m * 34.68, y + 33.5);
    glVertex2f(x + m * 34.68, y + 45.46);
    glVertex2f(x + m * 24.99, y + 45.46);
    glVertex2f(x + m * 5.78, y + 10.08);
    glVertex2f(x + m * 15.47, y + 10.08);
    glVertex2f(x + m * 15.47, y + 22.04);
    glVertex2f(x + m * 5.78, y + 22.04);
    glVertex2f(x + m * 24.81, y + 10.08);
    glVertex2f(x + m * 34.5, y + 10.08);
    glVertex2f(x + m * 34.5, y + 22.04);
    glVertex2f(x + m * 24.81, y + 22.04);
    glVertex2f(x + m * 46.73, y + 9.84);

    // glColor3ub(24,200,155);
    // glBegin(GL_QUADS);
    glVertex2f(x + m * 56.41, y + 9.84);
    glVertex2f(x + m * 56.41, y + 21.8);
    glVertex2f(x + m * 46.73, y + 21.8);
    glVertex2f(x + m * 46.73, y + 33.65);
    glVertex2f(x + m * 56.58, y + 33.65);
    glVertex2f(x + m * 56.58, y + 45.61);
    glVertex2f(x + m * 46.9, y + 45.61);
    glVertex2f(x + m * 65.8, y + 33.41);
    glVertex2f(x + m * 75.55, y + 33.41);
    glVertex2f(x + m * 75.55, y + 45.37);
    glVertex2f(x + m * 65.87, y + 45.37);
    glVertex2f(x + m * 84.75, y + 33.29);
    glVertex2f(x + m * 94.44, y + 33.29);
    glVertex2f(x + m * 94.44, y + 45.25);
    glVertex2f(x + m * 84.75, y + 45.25);
    glVertex2f(x + m * 84.88, y + 10.09);
    glVertex2f(x + m * 94.56, y + 10.09);
    glVertex2f(x + m * 94.56, y + 22.05);
    glVertex2f(x + m * 84.88, y + 22.05);
    glEnd();
    //door

    glColor3ub(65, 130, 70);
    glBegin(GL_QUADS);
    glVertex2f(x + m * 65.8, y + 0.08);
    glVertex2f(x + m * 75.48, y + 0.11);
    glVertex2f(x + m * 75.48, y + 21.85);
    glVertex2f(x + m * 65.8, y + 21.85);
    glEnd();
    //chimney left
    glColor3ub(245, 180, 30);
    glBegin(GL_QUADS);
    glVertex2f(x + m * 44.27, y + 66.72);
    glVertex2f(x + m * 48.7, y + 61.97);
    glVertex2f(x + m * 48.7, y + 78.82);
    glVertex2f(x + m * 44.27, y + 78.82);
    glEnd();
    //chimney front
    glColor3ub(255, 130, 160);
    glBegin(GL_QUADS);
    glVertex2f(x + m * 48.7, y + 61.97);
    glVertex2f(x + m * 55.23, y + 61.97);
    glVertex2f(x + m * 55.23, y + 78.8);
    glVertex2f(x + m * 48.7, y + 78.82);
    glEnd();
}
void house4()
{
    //main body
    glColor3ub(255, 100, 60);
    glBegin(GL_QUADS);
    glVertex2f(0, 0);
    glVertex2f(56.43, -0.05);
    glVertex2f(51.41, 70.25);
    glVertex2f(4.73, 70.25);
    //throat
    glColor3ub(125, 130, 100);
    glBegin(GL_QUADS);
    glVertex2f(7.3, 70.25);
    glVertex2f(49.04, 70.25);
    glVertex2f(49.04, 76.52);
    glVertex2f(7.3, 76.52);
    //door
    glColor3ub(25, 20, 50);
    glBegin(GL_QUADS);
    glVertex2f(22.34, -0.02);
    glVertex2f(33.36, -0.03);
    glVertex2f(33.36, 18.94);
    glVertex2f(22.34, 18.94);
    //window
    glColor3ub(255, 200, 90);
    glBegin(GL_QUADS);
    glVertex2f(25.21, 29.74);
    glVertex2f(30.9, 29.74);
    glVertex2f(30.91, 40.45);
    glVertex2f(25.21, 40.45);
    glVertex2f(25.17, 51.55);
    glVertex2f(30.87, 51.55);
    glVertex2f(30.88, 62.26);
    glVertex2f(25.17, 62.26);
    glEnd();
    //roof
    glColor3ub(26, 110, 30);
    glBegin(GL_TRIANGLES);
    glVertex2f(-0.52, 76.52);
    glVertex2f(57, 76.52);
    glVertex2f(28.42,91.33);
    glEnd();
}

void display()
{
    //sky

    //airplanes and birds

    //rear mountain
    
    //front mountain
   
    //shadow-light

    //shadow-dark

    //far ground

    //house

    //far trees

    //river

    //river wave marks

    //near ground

    //ground marks

    //boats

    //tent

    //near trees

    //fire

    glFlush();
}

void init(void)
{
    glClearColor(0.0F, 0.0F, 0.0F, 1);
    glMatrixMode(GL_PROJECTION);
    glLoadIdentity();
    glOrtho(0, 1920, 0, 1080, -100, 100);
}
int main(int argc, char **argv)
{
    glutInit(&argc, argv);
    glutInitDisplayMode(GLUT_RGB);
    glutInitWindowPosition(0, 0);
    glutInitWindowSize(1920, 1080);
    glutCreateWindow("Mountain Landscape");
    init();
    glutDisplayFunc(display);
    glutMainLoop();
}
