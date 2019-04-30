vec4 CompositeBottomAndTop(vec4 bottom, float bottomAlpha, vec4 top, float topAlpha) {
  vec4 outputBottom = vec4(bottomAlpha) * bottom;
  vec4 outputTop = vec4(topAlpha) * top;
  vec4 outputBlended = outputBottom * outputTop;
  vec4 returnMe = mix(outputBottom, mix(outputTop, outputBlended, outputBottom.a), outputTop.a);
  returnMe.a = 1.0;
  return returnMe;
}

vec4 CompositeBottom(vec4 bottom, float bottomAlpha) {
  vec4 returnMe = vec4(bottomAlpha) * bottom;
  returnMe.a = 1.0;
  return returnMe;
}

vec4 CompositeTop(vec4 top, float topAlpha) {
  vec4 returnMe = vec4(topAlpha) * top;
  returnMe.a = 1.0;
  return returnMe;
}
